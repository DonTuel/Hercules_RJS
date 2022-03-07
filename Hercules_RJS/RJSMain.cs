using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using ExpTreeLib;
using CustomExtensions;
using Hercules_RJS.Properties;

namespace Hercules_RJS
{
    public partial class RJSMain : Form
    {
        private XMLConfiguration XMLConfig = new XMLConfiguration();
        private readonly Globals gbl = new Globals();
        private HerculesConnection _herculesConnection;
        private Action<String> _invokeAction;

        private CShItem LastSelectedCSI;
        private readonly ManualResetEvent Event1 = new ManualResetEvent(true);
        private readonly DateTime testTime = new DateTime(1, 1, 1, 0, 0, 0);

        private static Boolean formLoading = true;
        //private Boolean dgvCustomizationChanged = false;

        private char[] delimiters = { '/', '\\' };

        public RJSMain()
        {
            InitializeComponent();
            MyInitialize();
        }

        private void MyInitialize()
        {
            SystemImageListManager.SetListViewImageList(lvDirectory, false, false);
            SystemImageListManager.SetListViewImageList(lvDirectory, true, false);
            txtPreJobText.TextChanged += new System.EventHandler(txtPreJobText_TextChanged);
            txtPostJobText.TextChanged += new System.EventHandler(txtPostJobText_TextChanged);

            rtbCustomizationHelp.Rtf = Resources.CustomizationHelp;
        }

        Int32 _buttonPressed = 0;
        String _fileName;
        private void txtFileView_DragEnter(object sender, DragEventArgs e)
        {
            if ((e.Data.GetDataPresent("FileDrop",true)) && 
                ((e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy))
            {
                e.Effect = DragDropEffects.Copy;
                if (e.KeyState == 2)
                {
                    _buttonPressed = 2;
                    //txtFileView.ContextMenuStrip = cmsDragDrop;
                    //cmsDragDrop.Show(txtFileView, txtFileView.Location.X + 80, txtFileView.Location.Y - 104);
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
                _buttonPressed = 0;
            }
        }

        private void txtFileView_DragDrop(object sender, DragEventArgs e)
        {
            String[] fList = (String[])e.Data.GetData("FileDrop", true);
            foreach (String str in fList)
            {
                if (_buttonPressed == 2) { _fileName = str; }
                else
                {
                    StreamReader fs = new StreamReader(str);
                    //txtFileView.Text += fs.ReadToEnd() + Environment.NewLine;
                    fs.Close();
                    fs = null;
                }
            }
            e.Effect = DragDropEffects.None;
        }

        private void RJSMain_Load(object sender, EventArgs e)
        {
            LoadConfiguration();
            formLoading = false;
        }

        private void LoadConfiguration()
        {
            //cfg.LoadConfiguration();

            XMLConfig = XMLConfiguration.Load(XMLConfiguration.GetSaveFileName());

            Left = XMLConfig.window.main.Left;
            Top = XMLConfig.window.main.Top;
            Height = XMLConfig.window.main.Height;
            Width = XMLConfig.window.main.Width;
            splitContainer1.SplitterDistance = XMLConfig.window.main.SplitContainer1SplitLocation;

            switch (XMLConfig.window.main.State)
            {
                case "Minimized":
                    WindowState = FormWindowState.Minimized;
                    break;
                case "Maximized":
                    WindowState = FormWindowState.Maximized;
                    break;
                default:
                    WindowState = FormWindowState.Normal;
                    break;
            }

            txtHerculesAddress.Text = XMLConfig.connection.HerculesIP;
            txtHerculesPort.Text = XMLConfig.connection.HerculesPort.ToString();
            rbConnectAtStartup.Checked = XMLConfig.connection.ConnectAtStartChecked.ToBool();
            rbConnectAtSubmit.Checked = XMLConfig.connection.ConnectAtSubmitChecked.ToBool();
            cbDisconnectAfterSubmit.Checked = XMLConfig.connection.DisconnectAfterSubmitChecked.ToBool();

            for (int i = 0; i < XMLConfig.replacementData.Count; i++)
            {
                if (XMLConfig.replacementData[i].FieldName != null && XMLConfig.replacementData[i].FieldName != "")
                {
                    Object[] cells = new Object[2];
                    cells[0] = XMLConfig.replacementData[i].FieldName;
                    cells[1] = XMLConfig.replacementData[i].ReplacementValue;
                    dgvCustomization.Rows.Add(cells);
                }
            }

            rbPreJobNone.Checked = XMLConfig.submitData.preJob.NoneChecked.ToBool();
            rbPreJobFile.Checked = XMLConfig.submitData.preJob.FileChecked.ToBool();
            txtPreJobFile.Text = XMLConfig.submitData.preJob.File;
            rbPreJobText.Checked = XMLConfig.submitData.preJob.TextChecked.ToBool();
            txtPreJobText.Text = XMLConfig.submitData.preJob.Text;
            rbPreJobFirstFile.Checked = XMLConfig.submitData.preJob.FirstFileChecked.ToBool();
            rbPreJobEveryFile.Checked = XMLConfig.submitData.preJob.EveryFileChecked.ToBool();
            rbPreJobInPlaceOfFile.Checked = XMLConfig.submitData.preJob.InPlaceOfFileChecked.ToBool();
            rbPostJobNone.Checked = XMLConfig.submitData.postJob.NoneChecked.ToBool();
            rbPostJobFile.Checked = XMLConfig.submitData.postJob.FileChecked.ToBool();
            txtPostJobFile.Text = XMLConfig.submitData.postJob.File;
            rbPostJobText.Checked = XMLConfig.submitData.postJob.TextChecked.ToBool();
            txtPostJobText.Text = XMLConfig.submitData.postJob.Text;
            rbPostJobFirstFile.Checked = XMLConfig.submitData.postJob.FirstFileChecked.ToBool();
            rbPostJobEveryFile.Checked = XMLConfig.submitData.postJob.EveryFileChecked.ToBool();

            cbVerboseLogging.Checked = XMLConfig.diagnostics.VerboseLoggingChecked.ToBool();
            cbProtocolLogging.Checked = XMLConfig.diagnostics.ProtocolLoggingChecked.ToBool();
            cbDumpPackets.Checked = XMLConfig.diagnostics.DumpPacketsChecked.ToBool();
            cbDisplayStatistics.Checked = XMLConfig.diagnostics.DisplayStatisticsChecked.ToBool();
            cbSubmitToFile.Checked = XMLConfig.diagnostics.SubmitToFileChecked.ToBool();
            txtSubmitToFile.Text = XMLConfig.diagnostics.SubmitToFileText;
            
            _herculesConnection = new HerculesConnection();
            _invokeAction = s => AppendOutput(s);

            if (rbConnectAtStartup.Checked)
            {
                ConnectToHercules();
            }

            XMLConfig.IsDirty = false;
        }

        private void RJSMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_herculesConnection.Connected)
            {
                _herculesConnection.Disconnect();
            }

            if ((XMLConfig.IsDirty) || WindowChanged())
            {
                SaveConfiguration();
            }
            Event1.Dispose();
        }

        private Boolean WindowChanged()
        {
            if (!((XMLConfig.window.main.State == WindowState.ToString()) &&
                (XMLConfig.window.main.Left == Left) &&
                (XMLConfig.window.main.Top == Top) &&
                (XMLConfig.window.main.Width == Width) &&
                (XMLConfig.window.main.Height == Height) &&
                (XMLConfig.window.main.SplitContainer1SplitLocation == splitContainer1.SplitterDistance)))
            {
                return true;
            }
            return false;
        }

        private void SaveConfiguration()
        {
            XMLConfig.window.main.State = WindowState.ToString();
            switch (WindowState)
            {
                case FormWindowState.Minimized:
                    break;
                case FormWindowState.Maximized:
                    break;
                default:
                    XMLConfig.window.main.Left = Left;
                    XMLConfig.window.main.Top = Top;
                    XMLConfig.window.main.Width = Width;
                    XMLConfig.window.main.Height = Height;
                    XMLConfig.window.main.SplitContainer1SplitLocation = splitContainer1.SplitterDistance;
                    break;
            }

            GetCustomizationData();

            XMLConfig.Save(XMLConfiguration.GetSaveFileName());
        }

        //  'The AppendOutput method could easily be replaced with a lambda method passed
        //  'to the ConnectionInfo contstructor in the ConnectButton_CheckChanged event handler
        private void AppendOutput(String message)
        {
            if (txtDiagnosticMessages.Text.Length > 0 )
            {
                txtDiagnosticMessages.AppendText(Environment.NewLine);
            }

            txtDiagnosticMessages.AppendText(message);
            txtDiagnosticMessages.ScrollToCaret();
        }

        private Boolean ConnectToHercules()
        {
            if (!_herculesConnection.Connect(txtHerculesAddress.Text, Convert.ToInt32(txtHerculesPort.Text), _invokeAction))
            {
                String errMsg = "Connection failed: " + _herculesConnection.ErrorMessage + "\n\nDo you wish to continue?";
                DialogResult dr = MessageBox.Show(errMsg, "Connection failure", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                {
                    this.Close();
                }
            }
            return _herculesConnection.Connected;
        }

        #region Main Menu
        private void mnuMainReconnect_Click(object sender, EventArgs e)
        {

        }

        private void mnuMainExit_Click(object sender, EventArgs e)
        {

        }

        private void mnuMainLargeIcons_Click(object sender, EventArgs e)
        {
            CheckSelectedView(mnuMainLargeIcons);
            lvDirectory.View = View.LargeIcon;
        }

        private void mnuMainSmallIcons_Click(object sender, EventArgs e)
        {
            CheckSelectedView(mnuMainSmallIcons);
            lvDirectory.View = View.SmallIcon;
        }

        private void mnuMainList_Click(object sender, EventArgs e)
        {
            CheckSelectedView(mnuMainList);
            lvDirectory.View = View.List;
        }

        private void mnuMainDetails_Click(object sender, EventArgs e)
        {
            CheckSelectedView(mnuMainDetails);
            lvDirectory.View = View.Details;
        }

        private void mnuMainSubmit_Click(object sender, EventArgs e)
        {
            SubmitJCL(null);
        }

        private void mnuMainAbout_Click(object sender, EventArgs e)
        {
            RJSAbout dlg = new RJSAbout();
            dlg.ShowDialog(this);
            dlg.Dispose();
            //dlg = null;
        }
        #endregion

        private void CheckSelectedView(ToolStripMenuItem item)
        {
            mnuMainLargeIcons.Checked = false;
            mnuMainSmallIcons.Checked = false;
            mnuMainList.Checked = false;
            mnuMainDetails.Checked = false;
            item.Checked = true;
        }

        private void LoadLV1Images()
        {
            foreach (ListViewItem lvi in lvDirectory.Items)
            {
                CShItem CSI = (CShItem)lvi.Tag;
                lvi.ImageIndex = SystemImageListManager.GetIconIndex(ref CSI, false, false);
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            if (sender is null)
            { }
        }

        private void GetCustomizationData()
        {
            XMLConfig.replacementData = new List<ReplacementData>();

            foreach (DataGridViewRow item in dgvCustomization.Rows)
            {
                String sourceValue = null;
                String replacementValue = null;
                if (item.Cells[0].Value != null)
                {
                    sourceValue = item.Cells[0].Value.ToString();
                }
                if (item.Cells[1].Value != null)
                {
                    replacementValue = item.Cells[1].Value.ToString();
                }
                else
                {
                    replacementValue = "";
                }
                if (sourceValue != null)
                {
                    ReplacementData data = new ReplacementData();
                    data.FieldName = sourceValue;
                    data.ReplacementValue = replacementValue;
                    XMLConfig.replacementData.Add(data);
                }
            }
        }

        private Object[] CustomizeJCL(ArrayList rawJCL, CShItem item)
        {
            String retJCL = rawJCL.UnSplit('\n');
            String fieldName;
            Char[] splitChars = new Char[] { '.', '/', '\\' };
            Char[] splitFolders = new Char[] { '/', '\\' };
            Char[] subStrs = new Char[] { '+' };

            GetCustomizationData();
            String[] fieldNames = new String[XMLConfig.replacementData.Count];

            for (int i = 0; i < XMLConfig.replacementData.Count; i++)
            {
                fieldNames[i] = XMLConfig.replacementData[i].FieldName;
            }

            int iFN = 0;

            while (iFN >= 0)
            {
                iFN = retJCL.FindAnyOf(fieldNames);
                if (iFN >= 0)
                {
                    fieldName = XMLConfig.replacementData[iFN].FieldName;
                    String[] repValues = XMLConfig.replacementData[iFN].ReplacementValue.Split(subStrs);
                    String replaceValue = string.Empty;
                    String replace = string.Empty;
                    foreach (String repItem in repValues)
                    {
                        String repValue = repItem;
                        Int32 rIdx = -1;
                        Int32 idx = repValue.Length;
                        if (repValue.Contains("["))
                        {
                            idx = repValue.IndexOf('[');
                            String str = repValue.Substring(idx + 1);
                            rIdx = Convert.ToInt32(str.Substring(0, str.IndexOf(']')));
                        }
                        if (repValue.Contains("("))
                        {
                            idx = repValue.IndexOf('(');
                            String str = repValue.Substring(idx + 1);
                            rIdx = Convert.ToInt32(str.Substring(0, str.IndexOf(')')));
                        }
                        repValue = repValue.Substring(0, idx);

                        if (repValue == "input")
                        {
                            DialogResult dr;
                            RJSReplaceValue dlg = new RJSReplaceValue();
                            dlg.SourceValue = fieldName;
                            dr = dlg.ShowDialog(this);
                            repValue = dlg.ReplaceValue;
                        }

                        switch (repValue)
                        {
                            case "file":
                                if (item == null) { replaceValue = string.Empty; }
                                else { replaceValue = item.Path; }
                                break;

                            case "file.path":
                                if (item == null) { replaceValue = string.Empty; }
                                else { replaceValue = item.Path.Substring(0, item.Path.LastIndexOfAny(splitFolders)); }
                                break;

                            case "file.name":
                                if (item == null) { replaceValue = string.Empty; }
                                else
                                {
                                    replaceValue = item.GetFileName();
                                    if (replaceValue.Contains(".")) { replaceValue = replaceValue.Substring(0, replaceValue.IndexOf('.')); }
                                }
                                break;

                            case "file.fullname":
                                if (item == null) { replaceValue = string.Empty; }
                                else
                                {
                                    replaceValue = item.GetFileName();
                                }
                                break;

                            case "file.ext":
                            case "file.extension":
                                if (item == null) { replaceValue = string.Empty; }
                                else
                                {
                                    replaceValue = item.GetFileName();
                                    if (replaceValue.Contains(".")) { replaceValue = replaceValue.Substring(replaceValue.IndexOf('.') + 1); }
                                    else { replaceValue = string.Empty; }
                                }
                                break;

                            case "file.part":
                            case "file.parts":
                                if (item == null) { replaceValue = string.Empty; }
                                else
                                {
                                    String[] parts = item.Path.Substring(0, item.Path.LastIndexOfAny(splitFolders)).Split(splitFolders);
                                    if (rIdx >= parts.Length) { replaceValue = string.Empty; }
                                    else { replaceValue = parts[rIdx]; }
                                }
                                break;

                            case "file.partr":
                            case "file.partsr":
                                if (item == null) { replaceValue = string.Empty; }
                                else
                                {
                                    String[] parts = item.Path.Substring(0, item.Path.LastIndexOfAny(splitFolders)).Split(splitFolders);
                                    if (rIdx >= parts.Length) { replaceValue = string.Empty; }
                                    else { replaceValue = parts[parts.Length - (rIdx + 1)]; }
                                }
                                break;

                            case "date":
                                if (item == null) { replaceValue = DateTime.Today.ToShortDateString(); }
                                else
                                {
                                    replaceValue = item.CreationTime.Date.ToShortDateString();
                                }
                                break;

                            case "date.year":
                            case "date.yyyy":
                                if (item == null) { replaceValue = DateTime.Today.Year.ToString(); }
                                else
                                {
                                    replaceValue = item.CreationTime.Date.Year.ToString();
                                }
                                break;

                            case "date.yy":
                                if (item == null) { replaceValue = DateTime.Today.Year.ToString().Substring(2, 2); }
                                else
                                {
                                    replaceValue = item.CreationTime.Date.Year.ToString().Substring(2, 2);
                                }
                                break;

                            case "date.mm":
                                if (item == null) { replaceValue = DateTime.Today.Month.ToString(); }
                                else
                                {
                                    replaceValue = item.CreationTime.Date.Month.ToString();
                                }
                                break;

                            case "date.dd":
                                if (item == null) { replaceValue = DateTime.Today.Day.ToString(); }
                                else
                                {
                                    replaceValue = item.CreationTime.Date.Day.ToString();
                                }
                                break;

                            case "time":
                                if (item == null) { replaceValue = DateTime.Today.ToShortTimeString(); }
                                else
                                {
                                    replaceValue = item.CreationTime.Date.ToShortTimeString();
                                }
                                break;

                            case "time.hh":
                                if (item == null) { replaceValue = DateTime.Today.Hour.ToString(); }
                                else
                                {
                                    replaceValue = item.CreationTime.Date.Hour.ToString();
                                }
                                break;

                            case "time.mm":
                                if (item == null) { replaceValue = DateTime.Today.Minute.ToString(); }
                                else
                                {
                                    replaceValue = item.CreationTime.Date.Minute.ToString();
                                }
                                break;

                            case "time.ss":
                                if (item == null) { replaceValue = DateTime.Today.Second.ToString(); }
                                else
                                {
                                    replaceValue = item.CreationTime.Date.Second.ToString();
                                }
                                break;

                            default:
                                replaceValue = repValue;
                                break;
                        }

                        if (ckbFoldUpperCase.Checked)
                        {
                            replaceValue = replaceValue.ToUpper();
                        }
                        replace += replaceValue;
                    }
                    if (fieldName.Length > 0)
                    {
                        retJCL = retJCL.Replace(fieldName, replace);
                    }
                }
            }

            if (retJCL != string.Empty)
            {
                return retJCL.Split('\n');
            }
            return new string[0];
        }

        private Object[] ProcessPreJobData(CShItem item)
        {
            ArrayList lines = new ArrayList();

            if (rbPreJobFile.Checked)
            {
                if (File.Exists(txtPreJobFile.Text))
                {
                    Stream fs = new FileStream(txtPreJobFile.Text, FileMode.Open, FileAccess.Read);
                    StreamReader sr = new StreamReader(fs);
                    do
                    {
                        lines.Add(sr.ReadLine());
                    } while (!sr.EndOfStream);
                }
            }

            if (rbPreJobText.Checked)
            {
                lines.AddRange(txtPreJobText.Lines);
            }

            return lines.ToArray();
        }

        private Object[] ProcessPostJobData(CShItem item)
        {
            ArrayList lines = new ArrayList();

            if (rbPostJobFile.Checked)
            {
                Stream fs = new FileStream(txtPostJobFile.Text, FileMode.Open, FileAccess.Read);
                StreamReader sr = new StreamReader(fs);
                do
                {
                    lines.Add(sr.ReadLine());
                } while (!sr.EndOfStream);
            }

            if (rbPostJobText.Checked)
            {
                lines.AddRange(txtPostJobText.Lines);
            }

            return lines.ToArray();
        }

        private Object[] ProcessSelectedFile(CShItem item)
        {
            if (item == null)
            {
                return new String[1];
            }

            Stream fs = new FileStream(item.Path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            ArrayList lines = new ArrayList();

            do
            {
                lines.Add(sr.ReadLine());
            } while (!sr.EndOfStream);

            return lines.ToArray();
        }

        private String[] BuildSubmitStream()
        {
            ArrayList JCLStream = new ArrayList();
            DialogResult dr;
            CShItem cSh;
            String[] lines = new String[JCLStream.Count];
            int idx = 0;

            bool warnMsg = false;

            if (lvDirectory.CheckedItems.Count < 1)
            {
                if (rbPreJobNone.Checked && rbPostJobNone.Checked) { }
                else
                {
                    if ((rbPreJobFirstFile.Checked || rbPreJobEveryFile.Checked) && !rbPreJobNone.Checked) { warnMsg = true; }
                    if ((rbPostJobFirstFile.Checked || rbPostJobEveryFile.Checked) && !rbPostJobNone.Checked) { warnMsg = true; }
                }
            }
            if (warnMsg)
            {
                dr = MessageBox.Show("There are no selected jobs for pre/post processing.\n\nContinue?", "Prejob/Postjob Analysis", MessageBoxButtons.YesNo);
                if (dr == DialogResult.No)
                {
                    return null;
                }
            }

            GetCustomizationData();

            if (lvDirectory.CheckedItems.Count < 1 || rbPreJobInPlaceOfFile.Checked)
            {
                if (!rbPreJobNone.Checked)
                {
                    if (rbPreJobFirstFile.Checked || rbPreJobEveryFile.Checked || rbPreJobInPlaceOfFile.Checked)
                    {
                        JCLStream.AddRange(ProcessPreJobData(null));
                    }
                }
                if (!rbPostJobNone.Checked)
                {
                    if (rbPostJobFirstFile.Checked || rbPostJobEveryFile.Checked || rbPreJobInPlaceOfFile.Checked)
                    {
                        JCLStream.AddRange(ProcessPostJobData(null));
                    }
                }

                JCLStream = new ArrayList(CustomizeJCL(JCLStream, null));
            }
            else
            {
                for (int i = 0; i < lvDirectory.CheckedItems.Count; i++)
                {
                    cSh = (CShItem)lvDirectory.CheckedItems[i].Tag;
                    ArrayList rawStream = new ArrayList();
                    FileStream selectedFile = new FileStream(cSh.Path, FileMode.Open, FileAccess.Read);

                    if ((rbPreJobFirstFile.Checked && i == 0) || rbPreJobEveryFile.Checked) // || rbPreJobInPlaceOfFile.Checked)
                    {
                        rawStream.AddRange(ProcessPreJobData(cSh));
                    }

                    rawStream.AddRange(ProcessSelectedFile(cSh));

                    if ((rbPostJobFirstFile.Checked && i == 0) || rbPostJobEveryFile.Checked) // || rbPreJobInPlaceOfFile.Checked)
                    {
                        rawStream.AddRange(ProcessPostJobData(cSh));
                    }

                    JCLStream.AddRange(CustomizeJCL(rawStream, cSh));
                }
            }

            lines = new String[JCLStream.Count];
            foreach (Object line in JCLStream)
            {
                lines[idx++] = (String)line;
            }

            return lines;
        }

        public void SubmitJCL(String[] jcl)
        {
            Action<Byte[], int, int> sOut;
            FileStream file = null;

            if (cbSubmitToFile.Checked)
            {
                if (File.Exists(txtSubmitToFile.Text)) { File.Delete(txtSubmitToFile.Text); }
                file = File.Create(txtSubmitToFile.Text);
                sOut = (array, offset, count) => file.Write(array, offset, count);
            }
            else
            { 
                if (!_herculesConnection.Connected)
                {
                    ConnectToHercules();
                }
                sOut = (array, offset, count) => _herculesConnection.Stream.Write(array, offset, count);
            }

            if ((_herculesConnection.Connected) || (cbSubmitToFile.Checked))
            {
                String[] lines;
                if (jcl == null)
                {
                    lines = BuildSubmitStream();
                }
                else
                {
                    lines = jcl;
                }

                if (lines != null)
                {
                    Byte[] buffer = Encoding.ASCII.GetBytes(lines.UnSplit(Environment.NewLine));
                    sOut(buffer, 0, buffer.Length);
                }
            }

            if ((cbDisconnectAfterSubmit.Checked) && (_herculesConnection.Connected))
            {
                if (rbConnectAtSubmit.Checked)
                {
                    _herculesConnection.Disconnect();
                }
            }

            if (file != null)
            {
                file.Close();
            }
        }

        #region Pre-Job/Post-Job Tab
        private void rbPreJobNone_CheckedChanged(object sender, EventArgs e)
        {
            XMLConfig.submitData.preJob.NoneChecked = rbPreJobNone.Checked.ToString();
            if (rbPreJobNone.Checked)
            {
                txtPreJobFile.Enabled = false;
                txtPreJobText.Enabled = false;
                rbPreJobFirstFile.Enabled = false;
                rbPreJobEveryFile.Enabled = false;
                rbPreJobInPlaceOfFile.Enabled = false;
            }
            else
            {
                txtPreJobFile.Enabled = true;
                txtPreJobText.Enabled = true;
                rbPreJobFirstFile.Enabled = true;
                rbPreJobEveryFile.Enabled = true;
                rbPreJobInPlaceOfFile.Enabled = true;
            }
        }

        private void rbPreJobFile_CheckedChanged(object sender, EventArgs e)
        {
            XMLConfig.submitData.preJob.FileChecked = rbPreJobFile.Checked.ToString();
            if (rbPreJobFile.Checked)
            {
                rbPreJobText.Checked = false;
                txtPreJobFile.Enabled = true;
                btnPreJobFileBrowse.Enabled = true;
                txtPreJobText.Enabled = true;
                txtPreJobText.ReadOnly = true;
                lblPreJobSubmit.Enabled = true;
                rbPreJobFirstFile.Enabled = true;
                rbPreJobEveryFile.Enabled = true;
                lblPreJobSubmit.Text = "Submit above file:";

                if (File.Exists(txtPreJobFile.Text))
                {
                    txtPreJobText.Tag = "File";
                    StreamReader fs = new StreamReader(txtPreJobFile.Text);
                    txtPreJobText.Text = fs.ReadToEnd() + Environment.NewLine;
                    fs.Close();
                    fs.Dispose();
                }
            }
            else
            {
                txtPreJobFile.Enabled = false;
                btnPreJobFileBrowse.Enabled = false;
            }
            DisablePreJobSubmit();
        }

        private void rbPreJobText_CheckedChanged(object sender, EventArgs e)
        {
            XMLConfig.submitData.preJob.TextChecked = rbPreJobText.Checked.ToString();
            if (rbPreJobText.Checked)
            {
                rbPreJobFile.Checked = false;
                txtPreJobFile.Enabled = false;
                btnPreJobFileBrowse.Enabled = false;
                txtPreJobText.Enabled = true;
                txtPreJobText.ReadOnly = false;
                lblPreJobSubmit.Enabled = true;
                rbPreJobFirstFile.Enabled = true;
                rbPreJobEveryFile.Enabled = true;
                lblPreJobSubmit.Text = "Submit above text:";

                txtPreJobText.Tag = "Text";
                txtPreJobText.Text = XMLConfig.submitData.preJob.Text;
            }
            else
            {
                txtPreJobText.ReadOnly = true;
            }
            DisablePreJobSubmit();
        }

        private void rbPreJobFirst_CheckedChanged(object sender, EventArgs e)
        {
            XMLConfig.submitData.preJob.FirstFileChecked = rbPreJobFirstFile.Checked.ToString();
        }

        private void rbPreJobEvery_CheckedChanged(object sender, EventArgs e)
        {
            XMLConfig.submitData.preJob.EveryFileChecked = rbPreJobEveryFile.Checked.ToString();
        }

        private void rbPreJobInPlaceOfFile_CheckedChanged(object sender, EventArgs e)
        {
            XMLConfig.submitData.preJob.InPlaceOfFileChecked = rbPreJobInPlaceOfFile.Checked.ToString();
            if (rbPreJobInPlaceOfFile.Checked)
            {
                rbPostJobFirstFile.Enabled = false;
                rbPostJobEveryFile.Enabled = false;
            }
            else
            {
                if (rbPostJobFile.Checked || rbPostJobText.Checked)
                {
                    rbPostJobFirstFile.Enabled = true;
                    rbPostJobEveryFile.Enabled = true;
                }
            }
        }

        private void DisablePreJobSubmit()
        {
            if (!(rbPreJobText.Checked || rbPreJobFile.Checked))
            {
                lblPreJobSubmit.Enabled = false;
                rbPreJobFirstFile.Enabled = false;
                rbPreJobEveryFile.Enabled = false;
            }
        }

        private void btnPreJobFileBrowse_Click(object sender, EventArgs e)
        {
            string filter = "JCL files (*.jcl;*.job)|*.jcl;*.job|All files (*.*)|*.*";
            string str = JobFileBrowseName(txtPreJobFile.Text, filter);

            if (str != null && str != string.Empty)
            {
                txtPreJobFile.Text = str;
            }
        }

        private string JobFileBrowseName(string oldFileName, string filter)
        {
            string str = oldFileName;
            int i = str.LastIndexOfAny(delimiters);
            if (i >= 0)
            {
                str = str.Substring(0, i);
            }
            bool dirFound = Directory.Exists(str);
            while (!dirFound && str != string.Empty)
            {
                i = str.LastIndexOfAny(delimiters);
                if (i > 0)
                {
                    str = str.Substring(0, i);
                    dirFound = Directory.Exists(str);
                }
                else
                {
                    str = string.Empty;
                }
            }
            FileDialog dlg = new OpenFileDialog();
            dlg.Filter = filter;
            dlg.InitialDirectory = str;
            DialogResult dr = dlg.ShowDialog();

            if (dr == DialogResult.OK)
            {
                return dlg.FileName;
            }
            return string.Empty;
        }

        private void rbPostJobNone_CheckedChanged(object sender, EventArgs e)
        {
            XMLConfig.submitData.postJob.NoneChecked = rbPostJobNone.Checked.ToString();
            if (rbPostJobNone.Checked)
            {
                txtPostJobFile.Enabled = false;
                txtPostJobText.Enabled = false;
                rbPostJobFirstFile.Enabled = false;
                rbPostJobEveryFile.Enabled = false;
                //rbPostJobInPlaceOfFile.Enabled = false;
            }
            else
            {
                txtPostJobFile.Enabled = true;
                txtPostJobText.Enabled = true;
                if (!rbPreJobInPlaceOfFile.Checked)
                {
                    rbPostJobFirstFile.Enabled = true;
                    rbPostJobEveryFile.Enabled = true;
                }
            }
            DisablePostJobSubmit();
        }

        private void rbPostJobFile_CheckedChanged(object sender, EventArgs e)
        {
            XMLConfig.submitData.postJob.FileChecked = rbPostJobFile.Checked.ToString();
            if (rbPostJobFile.Checked)
            {
                rbPostJobText.Checked = false;
                txtPostJobFile.Enabled = true;
                btnPostJobFileBrowse.Enabled = true;
                txtPostJobText.Enabled = true;
                txtPostJobText.ReadOnly = true;
                lblPostJobSubmit.Enabled = true;
                if (!rbPreJobInPlaceOfFile.Checked)
                {
                    rbPostJobFirstFile.Enabled = true;
                    rbPostJobEveryFile.Enabled = true;
                }
                lblPostJobSubmit.Text = "Submit above file:";

                if (File.Exists(txtPostJobFile.Text))
                {
                    txtPostJobText.Tag = "File";
                    StreamReader fs = new StreamReader(txtPostJobFile.Text);
                    txtPostJobText.Text = fs.ReadToEnd() + Environment.NewLine;
                    fs.Close();
                    fs.Dispose();
                }
            }
            else
            {
                txtPostJobFile.Enabled = false;
                btnPostJobFileBrowse.Enabled = false;
            }
            DisablePostJobSubmit();
        }

        private void rbPostJobText_CheckedChanged(object sender, EventArgs e)
        {
            XMLConfig.submitData.postJob.TextChecked = rbPostJobText.Checked.ToString();
            if (rbPostJobText.Checked)
            {
                rbPostJobFile.Checked = false;
                txtPostJobFile.Enabled = false;
                btnPostJobFileBrowse.Enabled = false;
                txtPostJobText.Enabled = true;
                txtPostJobText.ReadOnly = false;
                lblPostJobSubmit.Enabled = true;
                if (!rbPreJobInPlaceOfFile.Checked)
                {
                    rbPostJobFirstFile.Enabled = true;
                    rbPostJobEveryFile.Enabled = true;
                }
                lblPostJobSubmit.Text = "Submit above text:";

                txtPostJobText.Tag = "Text";
                txtPostJobText.Text = XMLConfig.submitData.postJob.Text;
            }
            else
            {
                txtPostJobText.Enabled = false;
            }
            DisablePostJobSubmit();
        }

        private void rbPostJobFirst_CheckedChanged(object sender, EventArgs e)
        {
            XMLConfig.submitData.postJob.FirstFileChecked = rbPostJobFirstFile.Checked.ToString();
        }

        private void rbPostJobEvery_CheckedChanged(object sender, EventArgs e)
        {
            XMLConfig.submitData.postJob.EveryFileChecked = rbPostJobEveryFile.Checked.ToString();
        }

        private void DisablePostJobSubmit()
        {
            if (!(rbPostJobText.Checked || rbPostJobFile.Checked))
            {
                lblPostJobSubmit.Enabled = false;
                rbPostJobFirstFile.Enabled = false;
                rbPostJobEveryFile.Enabled = false;
            }
        }

        private void rbPostJobInPlaceOfFile_CheckedChanged(object sender, EventArgs e)
        {
            //XMLConfig.submitData.postJob.InPlaceOfFileChecked = rbPostJobInPlaceOfFile.Checked.ToString();
        }

        private void btnPostJobFileBrowse_Click(object sender, EventArgs e)
        {
            string filter = "JCL files (*.jcl;*.job)|*.jcl;*.job|All files (*.*)|*.*";
            string str = JobFileBrowseName(txtPostJobFile.Text, filter);

            if (str != null && str != string.Empty)
            {
                txtPostJobFile.Text = str;
            }
        }

        private void txtPreJobFile_TextChanged(object sender, EventArgs e)
        {
            XMLConfig.submitData.preJob.File = txtPreJobFile.Text;
        }

        private void txtPreJobText_TextChanged(object sender, EventArgs e)
        {
            if ((String)txtPreJobText.Tag == "Text")
            {
                if (XMLConfig.submitData.preJob.Text != txtPreJobText.Text)
                {
                    XMLConfig.submitData.preJob.Text = txtPreJobText.Text;
                }
            }
        }

        private void txtPostJobFile_TextChanged(object sender, EventArgs e)
        {
            XMLConfig.submitData.postJob.File = txtPostJobFile.Text;
        }

        private void txtPostJobText_TextChanged(object sender, EventArgs e)
        {
            if ((String)txtPostJobText.Tag == "Text")
            {
                if (XMLConfig.submitData.postJob.Text != txtPostJobText.Text)
                {
                    XMLConfig.submitData.postJob.Text = txtPostJobText.Text;
                }
            }
        }
        #endregion

        #region Job Customization Tab
        private void dgvCustomization_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!formLoading)
            {
                //dgvCustomizationChanged = true;
            }
        }
        #endregion

        #region Files Tab
        private void expTreeView_ExpTreeNodeSelected(string SelPath, CShItem CSI)
        {
            ArrayList dirList = new ArrayList();
            ArrayList fileList = new ArrayList();
            TreeNode tn = new TreeNode(SelPath, CSI);
            int TotalItems = 0;

            LastSelectedCSI = CSI;

            if (cboxExpTreeViewLocations.Items.Count > 0)
            {
                Int32 idx = FindtreeNode(tn, cboxExpTreeViewLocations.Items);

                if (idx < 0)
                {
                    cboxExpTreeViewLocations.Items.Add(tn);
                    cboxExpTreeViewLocations.SelectedIndex = cboxExpTreeViewLocations.Items.Count - 1;
                    XMLConfig.filesRecent.LastViewed = SelPath;
                }
                else
                {
                    cboxExpTreeViewLocations.SelectedIndex = idx;
                }
            }
            else
            {
                if (XMLConfig.filesRecent.LastViewed != null && XMLConfig.filesRecent.LastViewed != string.Empty)
                {
                    tn = new TreeNode(XMLConfig.filesRecent.LastViewed, null);
                }
                else
                {
                    if (!CSI.DisplayName.Equals(CShItem.strMyComputer))
                    {
                        XMLConfig.filesRecent.LastViewed = SelPath;
                    }
                }
                cboxExpTreeViewLocations.Items.Add(tn);
                cboxExpTreeViewLocations.Enabled = true;
                cboxExpTreeViewLocations.SelectedIndex = cboxExpTreeViewLocations.Items.Count - 1;
            }

            if (CSI == null)
            {
                string[] files = Directory.GetFiles(SelPath);
                fileList.AddRange(files);
            }
            else
            {
                if (CSI.DisplayName.Equals(CShItem.strMyComputer))
                {
                    dirList = CSI.GetDirectories();
                }
                else
                {
                    dirList = CSI.GetDirectories();
                    fileList = CSI.GetFiles();
                }
            }

            try
            {
                Event1.WaitOne();
            }
            catch (Exception)
            {
                //throw;
            }

            TotalItems = dirList.Count + fileList.Count;

            if (TotalItems > 0)
            {
                dirList.Sort();
                fileList.Sort();

                statusStrip1.Items[0].Text = SelPath + "  " + dirList.Count.ToString() + " Directories " + fileList.Count.ToString() + " Files";

                ArrayList combList = new ArrayList(TotalItems);
                combList.AddRange(dirList);
                combList.AddRange(fileList);

                //  Build the ListViewItems & add to lv1
                lvDirectory.BeginUpdate();
                this.Cursor = Cursors.WaitCursor;
                lvDirectory.Items.Clear();
                lvDirectory.Refresh();

                foreach (var listItem in combList)
                {
                    if (listItem is CShItem)
                    {
                        CShItem item = (CShItem)listItem;
                        if (item.IsFolder) { }
                        else
                        {
                            if (item.TypeName.ToLower().Contains("shortcut")) { }
                            else
                            {
                                ListViewItem lvi = new ListViewItem(item.DisplayName);

                                if (!item.IsDisk && item.IsFileSystem)
                                {
                                    FileAttributes attr = item.Attributes;
                                    StringBuilder SB = new StringBuilder();

                                    if (attr.HasFlag(FileAttributes.System)) { SB.Append("S"); }
                                    if (attr.HasFlag(FileAttributes.Hidden)) { SB.Append("H"); }
                                    if (attr.HasFlag(FileAttributes.ReadOnly)) { SB.Append("R"); }
                                    if (attr.HasFlag(FileAttributes.Archive)) { SB.Append("A"); }

                                    lvi.SubItems.Add(SB.ToString());
                                }
                                else
                                {
                                    lvi.SubItems.Add("");
                                }

                                if (!item.IsDisk && item.IsFileSystem && !item.IsFolder)
                                    if (item.Length > 1024)
                                    {
                                        if (item.Length > 1048576)
                                        {
                                            lvi.SubItems.Add(String.Format("{0} MB", item.Length / 1048576));
                                        }
                                        else
                                        {
                                            lvi.SubItems.Add(String.Format("{0} KB", item.Length / 1024));
                                        }
                                    }
                                    else
                                    {
                                        lvi.SubItems.Add(String.Format("{0} bytes", item.Length));
                                    }
                                else
                                {
                                    lvi.SubItems.Add("");
                                }

                                lvi.SubItems.Add(item.TypeName);

                                if (!item.IsDisk)
                                {
                                    lvi.SubItems.Add("");
                                }
                                else
                                {
                                    if (item.LastWriteTime == testTime)
                                    {
                                        lvi.SubItems.Add(" ");
                                    }
                                    else
                                    {
                                        lvi.SubItems.Add(item.LastWriteTime.ToString());
                                    }
                                }

                                CShItem refItem = item;
                                lvi.ImageIndex = SystemImageListManager.GetIconIndex(ref refItem, false, false);
                                lvi.Tag = item;
                                lvDirectory.Items.Add(lvi);
                            }
                        }
                    }
                    else if (listItem is string)
                    {

                    }
                }

                this.Cursor = Cursors.Default;
                lvDirectory.EndUpdate();
                LoadLV1Images();
            }
            else
            {
                lvDirectory.Items.Clear();
                statusStrip1.Text = SelPath + " Has No Items";
            }
        }

        private void cboxExpTreeViewLocations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!formLoading)
            {
                Int32 idx = cboxExpTreeViewLocations.SelectedIndex;
                if (idx >= 0)
                {
                    TreeNode item = (TreeNode)cboxExpTreeViewLocations.Items[idx];
                    expTreeView_ExpTreeNodeSelected(item.path, item.item);
                }
            }
        }

        private Int32 FindtreeNode(TreeNode tn, ComboBox.ObjectCollection items)
        {
            for (int i = 0; i < items.Count; i++)
            {
                TreeNode tnI = (TreeNode)items[i];
                if (tn.path == tnI.path)
                {
                    return i;
                }
            }
            return -1;
        }
        #endregion

        #region Connection Tab

        private void rbDoNotConnect_CheckedChanged(object sender, EventArgs e)
        {
            btnConnect.Enabled = false;
            btnDisconnect.Enabled = false;
        }

        private void rbConnectAtStartup_CheckedChanged(object sender, EventArgs e)
        {
            XMLConfig.connection.ConnectAtStartChecked = rbConnectAtStartup.Checked.ToString();
            if (rbConnectAtStartup.Checked)
            {
                cbDisconnectAfterSubmit.Enabled = false;
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = true;
            }
            else
            {

            }
        }

        private void rbConnectAtSubmit_CheckedChanged(object sender, EventArgs e)
        {
            XMLConfig.connection.ConnectAtSubmitChecked = rbConnectAtSubmit.Checked.ToString();
            if (rbConnectAtSubmit.Checked)
            {
                cbDisconnectAfterSubmit.Enabled = true;
                btnConnect.Enabled = true;
                btnDisconnect.Enabled = true;
            }
            else
            {
                cbDisconnectAfterSubmit.Enabled = false;
            }
        }

        private void cbDisconnectAfterSubmit_CheckedChanged(object sender, EventArgs e)
        {
            XMLConfig.connection.DisconnectAfterSubmitChecked = cbDisconnectAfterSubmit.Checked.ToString();
        }

        private void txtHerculesAddress_TextChanged(object sender, EventArgs e)
        {
            if (XMLConfig.connection.HerculesIP != txtHerculesAddress.Text)
            {
                XMLConfig.connection.HerculesIP = txtHerculesAddress.Text;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            DialogResult dr;

            if (_herculesConnection.Connected)
            {
                MessageBox.Show("Already connected. You must disconnect first.");
                return;
            }

            while (!_herculesConnection.Connected)
            {
                if (!_herculesConnection.Connect(txtHerculesAddress.Text, Convert.ToInt32(txtHerculesPort.Text), _invokeAction))
                {
                    String errMsg = "Connection failed: " + _herculesConnection.ErrorMessage + "\n\nDo you wish to retry?";
                    dr = MessageBox.Show(errMsg, "Connection failure", MessageBoxButtons.YesNo);
                    if (dr == DialogResult.No)
                    {
                        return;
                    }
                }
            }
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            if (!_herculesConnection.Connected)
            {
                MessageBox.Show("Not connected. You must connect first.");
                return;
            }
            _herculesConnection.Disconnect();
        }

        private void txtPort_TextChanged(object sender, EventArgs e)
        {
            XMLConfig.connection.HerculesPort = Convert.ToInt32(txtHerculesPort.Text);
        }
        #endregion

        #region Diagnostics Tab
        private void cbVerboseLogging_CheckedChanged(object sender, EventArgs e)
        {
            XMLConfig.diagnostics.VerboseLoggingChecked = cbVerboseLogging.Checked.ToString();
        }

        private void cbProtocolLogging_CheckedChanged(object sender, EventArgs e)
        {
            XMLConfig.diagnostics.ProtocolLoggingChecked = cbProtocolLogging.Checked.ToString();
        }

        private void cbDumpPackets_CheckedChanged(object sender, EventArgs e)
        {
            XMLConfig.diagnostics.DumpPacketsChecked = cbDumpPackets.Checked.ToString();
        }

        private void cbDisplayStatistics_CheckedChanged(object sender, EventArgs e)
        {
            XMLConfig.diagnostics.DisplayStatisticsChecked = cbDisplayStatistics.Checked.ToString();
        }

        private void cbSubmitToFile_CheckedChanged(object sender, EventArgs e)
        {
            txtSubmitToFile.Enabled = cbSubmitToFile.Checked;
            btnSubmitToFileBrowse.Enabled = cbSubmitToFile.Checked;
            XMLConfig.diagnostics.SubmitToFileChecked = cbSubmitToFile.Checked.ToString();
        }

        private void txtSubmitToFile_TextChanged(object sender, EventArgs e)
        {
            XMLConfig.diagnostics.SubmitToFileText = txtSubmitToFile.Text;
        }

        private void btnSubmitToFileBrowse_Click(object sender, EventArgs e)
        {
            string filter = "RJS files (*.rjs)|*.rjs|All files (*.*)|*.*";
            string str = JobFileBrowseName(txtSubmitToFile.Text, filter);

            if (str != null && str != string.Empty)
            {
                txtSubmitToFile.Text = str;
            }
        }
        #endregion

        private void btnPreview_Click(object sender, EventArgs e)
        {
            DialogResult dr;
            RJSPreview rJS = new RJSPreview();
            rJS.EditBox.LineNumberPanelVisible = XMLConfig.window.preview.ShowLineNumbers.ToBool();
            rJS.ViewShowLineNumbers = XMLConfig.window.preview.ShowLineNumbers.ToBool();
            String[] lines = BuildSubmitStream();
            if (lines != null && lines.Length > 0)
            {
                rJS.EditBox.Lines = lines;
                rJS.ShowDialog(this);
                XMLConfig.window.preview.ShowLineNumbers = rJS.ViewShowLineNumbers.ToString();
            }
            else
            {
                dr = MessageBox.Show("There is nothing to preview.", "Preview empty", MessageBoxButtons.OK);
                if (dr == DialogResult.No)
                {
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SubmitJCL(null);
        }

        private void lvDirectory_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach (ListViewItem item in lvDirectory.SelectedItems)
            //{
            //    item.Checked = !item.Checked;
            //}
        }

        private void lvDirectory_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //foreach (ListViewItem item in lvDirectory.SelectedItems)
            //{
            //    item.Checked = !item.Checked;
            //}
        }

        private void lvDirectory_Click(object sender, EventArgs e)
        {
            //foreach (ListViewItem item in lvDirectory.SelectedItems)
            //{
            //    item.Checked = !item.Checked;
            //}
        }

        private void lvDirectory_DoubleClick(object sender, EventArgs e)
        {
            CShItem csi = (CShItem)lvDirectory.SelectedItems[0].Tag;

            if (csi.IsFolder)
            {
                expTreeView.ExpandANode(csi);
            }
            else
            {
            }
        }

        private void lvDirectory_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (lvDirectory.SelectedItems.Count > 0)
            {
                ArrayList toDrag = new ArrayList();
                String[] strD = new String[lvDirectory.SelectedItems.Count];
                Int32 i = 0;
                foreach (ListViewItem lvItem in lvDirectory.SelectedItems)
                {
                    toDrag.Add(lvItem.Tag);
                    CShItem cs = (CShItem)lvItem.Tag;
                    strD[i] = cs.Path;
                    i++;
                }
                DataObject dObj = new DataObject();
                MemoryStream ms;
                ms = CProcDataObject.MakeShellIDArray(toDrag);
                if (!(ms == null))
                {
                    dObj.SetData("Shell IDList Array", true, ms);
                }
                dObj.SetData("FileDrop", true, strD);
                dObj.SetData(toDrag);
                DragDropEffects dEff;
                if (e.Button == MouseButtons.Right)
                {
                    dEff = DragDropEffects.Copy | DragDropEffects.Move | DragDropEffects.Link;
                }
                else
                {
                    dEff = DragDropEffects.Copy | DragDropEffects.Move;
                }
                DragDropEffects res = lvDirectory.DoDragDrop(dObj, dEff);
            }
        }

        private void tpFiles_Click(object sender, EventArgs e)
        {
            if (sender == null) { }
        }

        private void tpFiles_Enter(object sender, EventArgs e)
        {
            if (sender == null) { }
        }
    }
}

using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace Hercules_RJS
{

    #region configuration XML classes
    [XmlRoot(ElementName = "Configuration")]
    public class XMLConfiguration
    {
        [XmlElement(ElementName = "Window")]
        public Window window;
        [XmlElement(ElementName = "Preferences")]
        public Preferences preferences;
        [XmlElement(ElementName = "SubmitData")]
        public SubmitData submitData;
        [XmlArray(ElementName = "CustomizationData")]
        [XmlArrayItem(ElementName = "ReplacementData")]
        public List<ReplacementData> replacementData;
        [XmlElement(ElementName = "FilesRecent")]
        public FilesRecent filesRecent;
        [XmlElement(ElementName = "Connection")]
        public Connection connection;
        [XmlElement(ElementName = "Diagnostics")]
        public Diagnostics diagnostics;

        private bool _isDirty = false;

        public XMLConfiguration()
        {
            window = new Window();
            preferences = new Preferences();
            submitData = new SubmitData();
            filesRecent = new FilesRecent();
            connection = new Connection();
            diagnostics = new Diagnostics();
            replacementData = new List<ReplacementData>();
        }

        [XmlIgnore]
        public virtual bool IsDirty
        {
            get
            {
                if (window.main.IsDirty || window.preview.IsDirty || preferences.IsDirty ||
                    submitData.preJob.IsDirty || submitData.postJob.IsDirty || filesRecent.IsDirty ||
                    connection.IsDirty || diagnostics.IsDirty)
                {
                    _isDirty = true;
                }

                if (!_isDirty)
                {
                    foreach (var item in replacementData)
                    {
                        if (item.IsDirty)
                        {
                            _isDirty = true;
                            break;
                        }
                    }
                }

                return _isDirty;
            }
            set
            {
                _isDirty = value;
                window.main.IsDirty = value;
                window.preview.IsDirty = value;
                preferences.IsDirty = value;
                submitData.preJob.IsDirty = value;
                submitData.postJob.IsDirty = value;
                connection.IsDirty = value;
                diagnostics.IsDirty = value;
                foreach (var item in replacementData)
                {
                    item.IsDirty = value;
                }
            }
        }

        public static XMLConfiguration Load(string path)
        {
            XMLConfiguration cfg;
            var serializer = new XmlSerializer(typeof(XMLConfiguration));
            if (File.Exists(path))
            {
                using (var stream = new FileStream(path, FileMode.Open))
                {
                    cfg = serializer.Deserialize(stream) as XMLConfiguration;
                    cfg.IsDirty = false;
                    return cfg;
                }
            }
            cfg = new XMLConfiguration();
            cfg.window.main.Width = 1160;
            cfg.window.main.Height = 970;
            cfg.window.main.Left = 560;
            cfg.window.main.Top = 110;
            cfg.window.main.State = "Normal";
            cfg.window.main.SplitContainer1SplitLocation = 460;
            cfg.window.preview.ShowLineNumbers = "True";
            cfg.IsDirty = false;
            return cfg;
        }

        public static string GetSaveFileName()
        {
            string sFileName;

            string commonAppDataPath = Application.CommonAppDataPath;
            //RegistryKey commonAppDataRegistry = Application.CommonAppDataRegistry;
            //string executablePath = Application.ExecutablePath;
            //string localUserAppDataPath = Application.LocalUserAppDataPath;
            //string startupPath = Application.StartupPath;
            //string userAppDataPath = Application.UserAppDataPath;
            //RegistryKey userAppDataRegistry = Application.UserAppDataRegistry;

            //string companyName = Application.CompanyName;
            string productName = Application.ProductName;
            string productVersion = Application.ProductVersion;

            sFileName = commonAppDataPath.Replace("dba ", "");
            sFileName = sFileName.Replace(productVersion, "");
            sFileName += productName + ".xml";

            return sFileName;
        }

        public void Save(string path)
        {
            XmlSerializerNamespaces ns = new XmlSerializerNamespaces(new[] { XmlQualifiedName.Empty });
            var serializer = new XmlSerializer(typeof(XMLConfiguration));
            using (var stream = new FileStream(path, FileMode.Create))
            {
                serializer.Serialize(stream, this, ns);
            }
        }
    }

    [XmlRoot(ElementName = "Window")]
    public class Window
    {
        [XmlElement(ElementName = "Main")]
        public Main main;
        [XmlElement(ElementName = "Preview")]
        public Preview preview;

        public Window()
        {
            main = new Main();
            preview = new Preview();
        }
    }

    [XmlRoot(ElementName = "Main")]
    public class Main
    {
        private int _Width;
        private int _Height;
        private int _Left;
        private int _Top;
        private string _State;
        private int _SplitContainer1SplitLocation;

        public int Width
        {
            get { return _Width; }
            set { _Width = value; _isDirty = true; }
        }
        public int Height
        {
            get { return _Height; }
            set { _Height = value; _isDirty = true; }
        }
        public int Left
        {
            get { return _Left; }
            set { _Left = value; _isDirty = true; }
        }
        public int Top
        {
            get { return _Top; }
            set { _Top = value; _isDirty = true; }
        }
        public string State
        {
            get { return _State; }
            set { _State = value; _isDirty = true; }
        }

        public int SplitContainer1SplitLocation
        {
            get { return _SplitContainer1SplitLocation; }
            set { _SplitContainer1SplitLocation = value; _isDirty = true; }
        }

        private bool _isDirty = false;
        [XmlIgnore]
        public bool IsDirty
        {
            get { return _isDirty; }
            set { _isDirty = value; }
        }

        public Main()
        {
            IsDirty = false;
        }
    }

    [XmlRoot(ElementName = "Preview")]
    public class Preview
    {
        private bool _isDirty = false;

        private string _ShowLineNumbers;

        [XmlElement(ElementName = "ShowLineNumbers")]
        public string ShowLineNumbers
        {
            get { return _ShowLineNumbers; }
            set { _ShowLineNumbers = value; _isDirty = true; }
        }

        [XmlIgnore]
        public bool IsDirty
        {
            get { return _isDirty; }
            set { _isDirty = value; }
        }
    }

    [XmlRoot(ElementName = "Preferences")]
    public class Preferences
    {
        private bool _isDirty = false;

        private string _DebugChecked;
        private string _DebugErrorsChecked;
        private string _Editor;
        private int _EditorOfChoice;
        private List<string> _Extensions;
        private int _ListFontSize;
        private string _OutputType;
        private string _TraceChecked;

        public string DebugChecked
        {
            get { return _DebugChecked; }
            set { _DebugChecked = value; _isDirty = true; }
        }
        public string DebugErrorsChecked
        {
            get { return _DebugErrorsChecked; }
            set { _DebugErrorsChecked = value; _isDirty = true; }
        }
        public string DefaultExtension { get; set; }
        public string Editor
        {
            get { return _Editor; }
            set { _Editor = value; _isDirty = true; }
        }
        public int EditorOfChoice
        {
            get { return _EditorOfChoice; }
            set { _EditorOfChoice = value; _isDirty = true; }
        }
        [XmlArray(ElementName = "Extensions")]
        [XmlArrayItem(ElementName = "Extension")]
        public List<string> Extensions
        {
            get { return _Extensions; }
            set { _Extensions = value; _isDirty = true; }
        }
        public int ListFontSize
        {
            get { return _ListFontSize; }
            set { _ListFontSize = value; _isDirty = true; }
        }
        public string OutputType
        {
            get { return _OutputType; }
            set { _OutputType = value; _isDirty = true; }
        }
        public string TraceChecked
        {
            get { return _TraceChecked; }
            set { _TraceChecked = value; _isDirty = true; }
        }

        [XmlIgnore]
        public bool IsDirty
        {
            get { return _isDirty; }
            set { _isDirty = value; }
        }
    }

    [XmlRoot(ElementName = "SubmitData")]
    public class SubmitData
    {
        [XmlElement(ElementName = "PreJob")]
        public SubmitJobData preJob;
        [XmlElement(ElementName = "PostJob")]
        public SubmitJobData postJob;

        public SubmitData()
        {
            preJob = new SubmitJobData();
            postJob = new SubmitJobData();
        }
    }

    public class SubmitJobData
    {
        private bool _isDirty = false;

        private string _NoneChecked;
        private string _FileChecked;
        private string _File;
        private string _TextChecked;
        private string _Text;
        private string _FirstFileChecked;
        private string _EveryFileChecked;
        private string _InPlaceOfFileChecked;

        public string NoneChecked
        {
            get { return _NoneChecked; }
            set { _NoneChecked = value; _isDirty = true; }
        }
        public string FileChecked
        {
            get { return _FileChecked; }
            set { _FileChecked = value; _isDirty = true; }
        }
        public string File
        {
            get { return _File; }
            set { _File = value; _isDirty = true; }
        }
        public string TextChecked
        {
            get { return _TextChecked; }
            set { _TextChecked = value; _isDirty = true; }
        }
        public string Text
        {
            get { return _Text; }
            set { _Text = value; _isDirty = true; }
        }
        public string FirstFileChecked
        {
            get { return _FirstFileChecked; }
            set { _FirstFileChecked = value; _isDirty = true; }
        }
        public string EveryFileChecked
        {
            get { return _EveryFileChecked; }
            set { _EveryFileChecked = value; _isDirty = true; }
        }
        public string InPlaceOfFileChecked
        {
            get { return _InPlaceOfFileChecked; }
            set { _InPlaceOfFileChecked = value; _isDirty = true; }
        }

        [XmlIgnore]
        public bool IsDirty
        {
            get { return _isDirty; }
            set { _isDirty = value; }
        }
    }

    [XmlRoot(ElementName = "FilesRecent")]
    public class FilesRecent
    {
        private bool _isDirty = false;

        private string _LastViewed;

        public string LastViewed
        {
            get { return _LastViewed; }
            set { _LastViewed = value; _isDirty = true; }
        }

        [XmlIgnore]
        public bool IsDirty
        {
            get { return _isDirty; }
            set { _isDirty = value; }
        }
    }

    [XmlRoot(ElementName = "Connection")]
    public class Connection
    {
        private bool _isDirty = false;

        private string _HerculesIP;
        private int _HerculesPort;
        private string _ConnectAtStartChecked;
        private string _ConnectAtSubmitChecked;
        private string _DisconnectAfterSubmitChecked;

        public string HerculesIP
        {
            get { return _HerculesIP; }
            set { _HerculesIP = value; _isDirty = true; }
        }
        public int HerculesPort
        {
            get { return _HerculesPort; }
            set { _HerculesPort = value; _isDirty = true; }
        }
        public string ConnectAtStartChecked
        {
            get { return _ConnectAtStartChecked; }
            set { _ConnectAtStartChecked = value; _isDirty = true; }
        }
        public string ConnectAtSubmitChecked
        {
            get { return _ConnectAtSubmitChecked; }
            set { _ConnectAtSubmitChecked = value; _isDirty = true; }
        }
        public string DisconnectAfterSubmitChecked
        {
            get { return _DisconnectAfterSubmitChecked; }
            set { _DisconnectAfterSubmitChecked = value; _isDirty = true; }
        }

        [XmlIgnore]
        public bool IsDirty
        {
            get { return _isDirty; }
            set { _isDirty = value; }
        }
    }

    [XmlRoot(ElementName = "Diagnostics")]
    public class Diagnostics
    {
        private bool _isDirty = false;

        private string _VerboseLoggingChecked;
        private string _DumpPacketsChecked;
        private string _DisplayStatisticsChecked;
        private string _ProtocolLoggingChecked;
        private string _SubmitToFileChecked;
        private string _SubmitToFileText;

        public string VerboseLoggingChecked
        {
            get { return _VerboseLoggingChecked; }
            set { _VerboseLoggingChecked = value; _isDirty = true; }
        }
        public string DumpPacketsChecked
        {
            get { return _DumpPacketsChecked; }
            set { _DumpPacketsChecked = value; _isDirty = true; }
        }
        public string DisplayStatisticsChecked
        {
            get { return _DisplayStatisticsChecked; }
            set { _DisplayStatisticsChecked = value; _isDirty = true; }
        }
        public string ProtocolLoggingChecked
        {
            get { return _ProtocolLoggingChecked; }
            set { _ProtocolLoggingChecked = value; _isDirty = true; }
        }
        public string SubmitToFileChecked
        {
            get { return _SubmitToFileChecked; }
            set { _SubmitToFileChecked = value; _isDirty = true; }
        }
        public string SubmitToFileText
        {
            get { return _SubmitToFileText; }
            set { _SubmitToFileText = value; _isDirty = true; }
        }

        [XmlIgnore]
        public bool IsDirty
        {
            get { return _isDirty; }
            set { _isDirty = value; }
        }
    }

    public class ReplacementData
    {
        private bool _isDirty = false;

        private string _FieldName;
        private string _ReplacementValue;

        [XmlAttribute(AttributeName = "FieldName")]
        public string FieldName
        {
            get { return _FieldName; }
            set { _FieldName = value; _isDirty = true; }
        }
        [XmlAttribute(AttributeName = "ReplacementValue")]
        public string ReplacementValue
        {
            get { return _ReplacementValue; }
            set { _ReplacementValue = value; _isDirty = true; }
        }

        [XmlIgnore]
        public bool IsDirty
        {
            get { return _isDirty; }
            set { _isDirty = value; }
        }
    }
    #endregion
}

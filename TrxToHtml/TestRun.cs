namespace TrxToHtml
{

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", IsNullable = false)]
    public partial class TestRun
    {

        private TestRunTestSettings testSettingsField;

        private TestRunTimes timesField;

        private TestRunResultSummary resultSummaryField;

        private TestRunUnitTest[] testDefinitionsField;

        private TestRunTestList[] testListsField;

        private TestRunTestEntry[] testEntriesField;

        private TestRunUnitTestResult[] resultsField;

        private string idField;

        private string nameField;

        private string runUserField;

        /// <remarks/>
        public TestRunTestSettings TestSettings
        {
            get
            {
                return this.testSettingsField;
            }
            set
            {
                this.testSettingsField = value;
            }
        }

        /// <remarks/>
        public TestRunTimes Times
        {
            get
            {
                return this.timesField;
            }
            set
            {
                this.timesField = value;
            }
        }

        /// <remarks/>
        public TestRunResultSummary ResultSummary
        {
            get
            {
                return this.resultSummaryField;
            }
            set
            {
                this.resultSummaryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("UnitTest", IsNullable = false)]
        public TestRunUnitTest[] TestDefinitions
        {
            get
            {
                return this.testDefinitionsField;
            }
            set
            {
                this.testDefinitionsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TestList", IsNullable = false)]
        public TestRunTestList[] TestLists
        {
            get
            {
                return this.testListsField;
            }
            set
            {
                this.testListsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TestEntry", IsNullable = false)]
        public TestRunTestEntry[] TestEntries
        {
            get
            {
                return this.testEntriesField;
            }
            set
            {
                this.testEntriesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("UnitTestResult", IsNullable = false)]
        public TestRunUnitTestResult[] Results
        {
            get
            {
                return this.resultsField;
            }
            set
            {
                this.resultsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string runUser
        {
            get
            {
                return this.runUserField;
            }
            set
            {
                this.runUserField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunTestSettings
    {

        private string descriptionField;

        private TestRunTestSettingsDeployment deploymentField;

        private TestRunTestSettingsExecution executionField;

        private object propertiesField;

        private string nameField;

        private string idField;

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        public TestRunTestSettingsDeployment Deployment
        {
            get
            {
                return this.deploymentField;
            }
            set
            {
                this.deploymentField = value;
            }
        }

        /// <remarks/>
        public TestRunTestSettingsExecution Execution
        {
            get
            {
                return this.executionField;
            }
            set
            {
                this.executionField = value;
            }
        }

        /// <remarks/>
        public object Properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunTestSettingsDeployment
    {

        private TestRunTestSettingsDeploymentDeploymentItem[] deploymentItemField;

        private string userDeploymentRootField;

        private bool useDefaultDeploymentRootField;

        private string runDeploymentRootField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DeploymentItem")]
        public TestRunTestSettingsDeploymentDeploymentItem[] DeploymentItem
        {
            get
            {
                return this.deploymentItemField;
            }
            set
            {
                this.deploymentItemField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string userDeploymentRoot
        {
            get
            {
                return this.userDeploymentRootField;
            }
            set
            {
                this.userDeploymentRootField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool useDefaultDeploymentRoot
        {
            get
            {
                return this.useDefaultDeploymentRootField;
            }
            set
            {
                this.useDefaultDeploymentRootField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string runDeploymentRoot
        {
            get
            {
                return this.runDeploymentRootField;
            }
            set
            {
                this.runDeploymentRootField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunTestSettingsDeploymentDeploymentItem
    {

        private string filenameField;

        private string outputDirectoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string filename
        {
            get
            {
                return this.filenameField;
            }
            set
            {
                this.filenameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string outputDirectory
        {
            get
            {
                return this.outputDirectoryField;
            }
            set
            {
                this.outputDirectoryField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunTestSettingsExecution
    {

        private TestRunTestSettingsExecutionTestTypeSpecific testTypeSpecificField;

        private TestRunTestSettingsExecutionAgentRule agentRuleField;

        private ushort parallelTestCountField;

        /// <remarks/>
        public TestRunTestSettingsExecutionTestTypeSpecific TestTypeSpecific
        {
            get
            {
                return this.testTypeSpecificField;
            }
            set
            {
                this.testTypeSpecificField = value;
            }
        }

        /// <remarks/>
        public TestRunTestSettingsExecutionAgentRule AgentRule
        {
            get
            {
                return this.agentRuleField;
            }
            set
            {
                this.agentRuleField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort parallelTestCount
        {
            get
            {
                return this.parallelTestCountField;
            }
            set
            {
                this.parallelTestCountField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunTestSettingsExecutionTestTypeSpecific
    {

        private TestRunTestSettingsExecutionTestTypeSpecificUnitTestRunConfig unitTestRunConfigField;

        private TestRunTestSettingsExecutionTestTypeSpecificWebTestRunConfiguration webTestRunConfigurationField;

        /// <remarks/>
        public TestRunTestSettingsExecutionTestTypeSpecificUnitTestRunConfig UnitTestRunConfig
        {
            get
            {
                return this.unitTestRunConfigField;
            }
            set
            {
                this.unitTestRunConfigField = value;
            }
        }

        /// <remarks/>
        public TestRunTestSettingsExecutionTestTypeSpecificWebTestRunConfiguration WebTestRunConfiguration
        {
            get
            {
                return this.webTestRunConfigurationField;
            }
            set
            {
                this.webTestRunConfigurationField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunTestSettingsExecutionTestTypeSpecificUnitTestRunConfig
    {

        private TestRunTestSettingsExecutionTestTypeSpecificUnitTestRunConfigAssemblyResolution assemblyResolutionField;

        private string testTypeIdField;

        /// <remarks/>
        public TestRunTestSettingsExecutionTestTypeSpecificUnitTestRunConfigAssemblyResolution AssemblyResolution
        {
            get
            {
                return this.assemblyResolutionField;
            }
            set
            {
                this.assemblyResolutionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string testTypeId
        {
            get
            {
                return this.testTypeIdField;
            }
            set
            {
                this.testTypeIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunTestSettingsExecutionTestTypeSpecificUnitTestRunConfigAssemblyResolution
    {

        private TestRunTestSettingsExecutionTestTypeSpecificUnitTestRunConfigAssemblyResolutionTestDirectory testDirectoryField;

        /// <remarks/>
        public TestRunTestSettingsExecutionTestTypeSpecificUnitTestRunConfigAssemblyResolutionTestDirectory TestDirectory
        {
            get
            {
                return this.testDirectoryField;
            }
            set
            {
                this.testDirectoryField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunTestSettingsExecutionTestTypeSpecificUnitTestRunConfigAssemblyResolutionTestDirectory
    {

        private bool useLoadContextField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool useLoadContext
        {
            get
            {
                return this.useLoadContextField;
            }
            set
            {
                this.useLoadContextField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunTestSettingsExecutionTestTypeSpecificWebTestRunConfiguration
    {

        private TestRunTestSettingsExecutionTestTypeSpecificWebTestRunConfigurationBrowser browserField;

        private string testTypeIdField;

        /// <remarks/>
        public TestRunTestSettingsExecutionTestTypeSpecificWebTestRunConfigurationBrowser Browser
        {
            get
            {
                return this.browserField;
            }
            set
            {
                this.browserField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string testTypeId
        {
            get
            {
                return this.testTypeIdField;
            }
            set
            {
                this.testTypeIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunTestSettingsExecutionTestTypeSpecificWebTestRunConfigurationBrowser
    {

        private TestRunTestSettingsExecutionTestTypeSpecificWebTestRunConfigurationBrowserHeader[] headersField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Header", IsNullable = false)]
        public TestRunTestSettingsExecutionTestTypeSpecificWebTestRunConfigurationBrowserHeader[] Headers
        {
            get
            {
                return this.headersField;
            }
            set
            {
                this.headersField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunTestSettingsExecutionTestTypeSpecificWebTestRunConfigurationBrowserHeader
    {

        private string nameField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunTestSettingsExecutionAgentRule
    {

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunTimes
    {

        private System.DateTime creationField;

        private System.DateTime queuingField;

        private System.DateTime startField;

        private System.DateTime finishField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime creation
        {
            get
            {
                return this.creationField;
            }
            set
            {
                this.creationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime queuing
        {
            get
            {
                return this.queuingField;
            }
            set
            {
                this.queuingField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime start
        {
            get
            {
                return this.startField;
            }
            set
            {
                this.startField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime finish
        {
            get
            {
                return this.finishField;
            }
            set
            {
                this.finishField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunResultSummary
    {

        private TestRunResultSummaryCounters countersField;

        private TestRunResultSummaryOutput outputField;

        private TestRunResultSummaryRunInfo[] runInfosField;

        private string outcomeField;

        /// <remarks/>
        public TestRunResultSummaryCounters Counters
        {
            get
            {
                return this.countersField;
            }
            set
            {
                this.countersField = value;
            }
        }

        /// <remarks/>
        public TestRunResultSummaryOutput Output
        {
            get
            {
                return this.outputField;
            }
            set
            {
                this.outputField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("RunInfo", IsNullable = false)]
        public TestRunResultSummaryRunInfo[] RunInfos
        {
            get
            {
                return this.runInfosField;
            }
            set
            {
                this.runInfosField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string outcome
        {
            get
            {
                return this.outcomeField;
            }
            set
            {
                this.outcomeField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunResultSummaryCounters
    {

        private ushort totalField;

        private ushort executedField;

        private ushort passedField;

        private ushort errorField;

        private ushort failedField;

        private ushort timeoutField;

        private ushort abortedField;

        private ushort inconclusiveField;

        private ushort passedButRunAbortedField;

        private ushort notRunnableField;

        private ushort notExecutedField;

        private ushort disconnectedField;

        private ushort warningField;

        private ushort completedField;

        private ushort inProgressField;

        private ushort pendingField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort total
        {
            get
            {
                return this.totalField;
            }
            set
            {
                this.totalField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort executed
        {
            get
            {
                return this.executedField;
            }
            set
            {
                this.executedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort passed
        {
            get
            {
                return this.passedField;
            }
            set
            {
                this.passedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort error
        {
            get
            {
                return this.errorField;
            }
            set
            {
                this.errorField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort failed
        {
            get
            {
                return this.failedField;
            }
            set
            {
                this.failedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort timeout
        {
            get
            {
                return this.timeoutField;
            }
            set
            {
                this.timeoutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort aborted
        {
            get
            {
                return this.abortedField;
            }
            set
            {
                this.abortedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort inconclusive
        {
            get
            {
                return this.inconclusiveField;
            }
            set
            {
                this.inconclusiveField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort passedButRunAborted
        {
            get
            {
                return this.passedButRunAbortedField;
            }
            set
            {
                this.passedButRunAbortedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort notRunnable
        {
            get
            {
                return this.notRunnableField;
            }
            set
            {
                this.notRunnableField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort notExecuted
        {
            get
            {
                return this.notExecutedField;
            }
            set
            {
                this.notExecutedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort disconnected
        {
            get
            {
                return this.disconnectedField;
            }
            set
            {
                this.disconnectedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort warning
        {
            get
            {
                return this.warningField;
            }
            set
            {
                this.warningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort completed
        {
            get
            {
                return this.completedField;
            }
            set
            {
                this.completedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort inProgress
        {
            get
            {
                return this.inProgressField;
            }
            set
            {
                this.inProgressField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public ushort pending
        {
            get
            {
                return this.pendingField;
            }
            set
            {
                this.pendingField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunResultSummaryOutput
    {

        private string stdOutField;

        private string debugTraceField;

        /// <remarks/>
        public string StdOut
        {
            get
            {
                return this.stdOutField;
            }
            set
            {
                this.stdOutField = value;
            }
        }

        /// <remarks/>
        public string DebugTrace
        {
            get
            {
                return this.debugTraceField;
            }
            set
            {
                this.debugTraceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunResultSummaryRunInfo
    {

        private string textField;

        private string computerNameField;

        private string outcomeField;

        private System.DateTime timestampField;

        /// <remarks/>
        public string Text
        {
            get
            {
                return this.textField;
            }
            set
            {
                this.textField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string computerName
        {
            get
            {
                return this.computerNameField;
            }
            set
            {
                this.computerNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string outcome
        {
            get
            {
                return this.outcomeField;
            }
            set
            {
                this.outcomeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime timestamp
        {
            get
            {
                return this.timestampField;
            }
            set
            {
                this.timestampField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunUnitTest
    {

        private string descriptionField;

        private TestRunUnitTestTestCategoryItem[] testCategoryField;

        private TestRunUnitTestDeploymentItem[] deploymentItemsField;

        private TestRunUnitTestExecution executionField;

        private TestRunUnitTestWorkitems workitemsField;

        private TestRunUnitTestProperties propertiesField;

        private TestRunUnitTestTestMethod testMethodField;

        private string nameField;

        private string storageField;

        private string idField;

        /// <remarks/>
        public string Description
        {
            get
            {
                return this.descriptionField;
            }
            set
            {
                this.descriptionField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("TestCategoryItem", IsNullable = false)]
        public TestRunUnitTestTestCategoryItem[] TestCategory
        {
            get
            {
                return this.testCategoryField;
            }
            set
            {
                this.testCategoryField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DeploymentItem", IsNullable = false)]
        public TestRunUnitTestDeploymentItem[] DeploymentItems
        {
            get
            {
                return this.deploymentItemsField;
            }
            set
            {
                this.deploymentItemsField = value;
            }
        }

        /// <remarks/>
        public TestRunUnitTestExecution Execution
        {
            get
            {
                return this.executionField;
            }
            set
            {
                this.executionField = value;
            }
        }

        /// <remarks/>
        public TestRunUnitTestWorkitems Workitems
        {
            get
            {
                return this.workitemsField;
            }
            set
            {
                this.workitemsField = value;
            }
        }

        /// <remarks/>
        public TestRunUnitTestProperties Properties
        {
            get
            {
                return this.propertiesField;
            }
            set
            {
                this.propertiesField = value;
            }
        }

        /// <remarks/>
        public TestRunUnitTestTestMethod TestMethod
        {
            get
            {
                return this.testMethodField;
            }
            set
            {
                this.testMethodField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string storage
        {
            get
            {
                return this.storageField;
            }
            set
            {
                this.storageField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunUnitTestTestCategoryItem
    {

        private string testCategoryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string TestCategory
        {
            get
            {
                return this.testCategoryField;
            }
            set
            {
                this.testCategoryField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunUnitTestDeploymentItem
    {

        private string filenameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string filename
        {
            get
            {
                return this.filenameField;
            }
            set
            {
                this.filenameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunUnitTestExecution
    {

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunUnitTestWorkitems
    {

        private uint workitemField;

        /// <remarks/>
        public uint Workitem
        {
            get
            {
                return this.workitemField;
            }
            set
            {
                this.workitemField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunUnitTestProperties
    {

        private TestRunUnitTestPropertiesProperty propertyField;

        /// <remarks/>
        public TestRunUnitTestPropertiesProperty Property
        {
            get
            {
                return this.propertyField;
            }
            set
            {
                this.propertyField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunUnitTestPropertiesProperty
    {

        private string keyField;

        private string valueField;

        /// <remarks/>
        public string Key
        {
            get
            {
                return this.keyField;
            }
            set
            {
                this.keyField = value;
            }
        }

        /// <remarks/>
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunUnitTestTestMethod
    {

        private string codeBaseField;

        private string adapterTypeNameField;

        private string classNameField;

        private string nameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string codeBase
        {
            get
            {
                return this.codeBaseField;
            }
            set
            {
                this.codeBaseField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string adapterTypeName
        {
            get
            {
                return this.adapterTypeNameField;
            }
            set
            {
                this.adapterTypeNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string className
        {
            get
            {
                return this.classNameField;
            }
            set
            {
                this.classNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunTestList
    {

        private string nameField;

        private string idField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunTestEntry
    {

        private string testIdField;

        private string executionIdField;

        private string testListIdField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string testId
        {
            get
            {
                return this.testIdField;
            }
            set
            {
                this.testIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string executionId
        {
            get
            {
                return this.executionIdField;
            }
            set
            {
                this.executionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string testListId
        {
            get
            {
                return this.testListIdField;
            }
            set
            {
                this.testListIdField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunUnitTestResult
    {

        private TestRunUnitTestResultOutput outputField;

        private string executionIdField;

        private string testIdField;

        private string testNameField;

        private string computerNameField;

        private System.DateTime durationField;

        private System.DateTime startTimeField;

        private System.DateTime endTimeField;

        private string testTypeField;

        private string outcomeField;

        private string testListIdField;

        private string relativeResultsDirectoryField;

        /// <remarks/>
        public TestRunUnitTestResultOutput Output
        {
            get
            {
                return this.outputField;
            }
            set
            {
                this.outputField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string executionId
        {
            get
            {
                return this.executionIdField;
            }
            set
            {
                this.executionIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string testId
        {
            get
            {
                return this.testIdField;
            }
            set
            {
                this.testIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string testName
        {
            get
            {
                return this.testNameField;
            }
            set
            {
                this.testNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string computerName
        {
            get
            {
                return this.computerNameField;
            }
            set
            {
                this.computerNameField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "time")]
        public System.DateTime duration
        {
            get
            {
                return this.durationField;
            }
            set
            {
                this.durationField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime startTime
        {
            get
            {
                return this.startTimeField;
            }
            set
            {
                this.startTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime endTime
        {
            get
            {
                return this.endTimeField;
            }
            set
            {
                this.endTimeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string testType
        {
            get
            {
                return this.testTypeField;
            }
            set
            {
                this.testTypeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string outcome
        {
            get
            {
                return this.outcomeField;
            }
            set
            {
                this.outcomeField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string testListId
        {
            get
            {
                return this.testListIdField;
            }
            set
            {
                this.testListIdField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string relativeResultsDirectory
        {
            get
            {
                return this.relativeResultsDirectoryField;
            }
            set
            {
                this.relativeResultsDirectoryField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunUnitTestResultOutput
    {

        private object[] itemsField;

        private ItemsChoiceType[] itemsElementNameField;

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DebugTrace", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("ErrorInfo", typeof(TestRunUnitTestResultOutputErrorInfo))]
        [System.Xml.Serialization.XmlElementAttribute("StdOut", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this.itemsField;
            }
            set
            {
                this.itemsField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this.itemsElementNameField;
            }
            set
            {
                this.itemsElementNameField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010")]
    public partial class TestRunUnitTestResultOutputErrorInfo
    {

        private string messageField;

        private string stackTraceField;

        /// <remarks/>
        public string Message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }

        /// <remarks/>
        public string StackTrace
        {
            get
            {
                return this.stackTraceField;
            }
            set
            {
                this.stackTraceField = value;
            }
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://microsoft.com/schemas/VisualStudio/TeamTest/2010", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        /// <remarks/>
        DebugTrace,

        /// <remarks/>
        ErrorInfo,

        /// <remarks/>
        StdOut,
    }


}
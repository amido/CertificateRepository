﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.34011
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace CertificateRepository.IntegrationTests.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("CertificateRepository exposes X509 Certificate Store")]
    public partial class CertificateRepositoryExposesX509CertificateStoreFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CertificateRepository.feature"
#line hidden
        
        [NUnit.Framework.TestFixtureSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "CertificateRepository exposes X509 Certificate Store", "Must be able to access certificates by Subject Name\r\nMust be able to access multi" +
                    "ple certificates by Subject Name\r\nMust be able to access certificates by Thumbpr" +
                    "int", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.TestFixtureTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Access single certificate from My store by Subject Name")]
        [NUnit.Framework.CategoryAttribute("CleanupCertificatesOnError")]
        public virtual void AccessSingleCertificateFromMyStoreBySubjectName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Access single certificate from My store by Subject Name", new string[] {
                        "CleanupCertificatesOnError"});
#line 7
  this.ScenarioSetup(scenarioInfo);
#line 8
    testRunner.Given("the certificate \'singleCertificate.pfx\' has been loaded using password \'abc123\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 9
   testRunner.And("place it into the \'My\' store for the \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 10
 testRunner.When("I create a certificate repository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 11
   testRunner.And("set the Store Name to \'My\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 12
   testRunner.And("set the Store Location to \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 13
   testRunner.And("I call FindBySubjectName with subject \'Single Certificate\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 14
    testRunner.Then("there should only be \'1\' certificate in the collection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 15
   testRunner.And("one certificate retrieved should match the thumbprint \'B0B7EEEA3EB2F7A927EB1B075B" +
                    "A6EF9906D928AE\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 16
 testRunner.Then("any certificates should be cleaned up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Access two certificates from My store by Subject Name")]
        [NUnit.Framework.CategoryAttribute("CleanupCertificatesOnError")]
        public virtual void AccessTwoCertificatesFromMyStoreBySubjectName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Access two certificates from My store by Subject Name", new string[] {
                        "CleanupCertificatesOnError"});
#line 19
  this.ScenarioSetup(scenarioInfo);
#line 20
    testRunner.Given("the certificate \'sampleCertificate.pfx\' has been loaded using password \'abc123\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 21
   testRunner.And("place it into the \'My\' store for the \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 22
   testRunner.And("the certificate \'additionalCertificate.pfx\' has been loaded using password \'abc12" +
                    "3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 23
   testRunner.And("place it into the \'My\' store for the \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 24
 testRunner.When("I create a certificate repository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 25
   testRunner.And("set the Store Name to \'My\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 26
   testRunner.And("set the Store Location to \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 27
   testRunner.And("I call FindBySubjectName with subject \'Sample Certificate\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
    testRunner.Then("there should be \'2\' certificates in the collection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 29
   testRunner.And("one certificate retrieved should match the thumbprint \'C21B70C4DA42C98C8C696A7820" +
                    "16585B5BF5223D\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 30
   testRunner.And("one certificate retrieved should match the thumbprint \'EFFF7FD55F1F37B67CCE6F5390" +
                    "71AD13A4BFA92C\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.Then("any certificates should be cleaned up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Find two similarlly named certificates from My store by Subject Name")]
        [NUnit.Framework.CategoryAttribute("CleanupCertificatesOnError")]
        public virtual void FindTwoSimilarllyNamedCertificatesFromMyStoreBySubjectName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Find two similarlly named certificates from My store by Subject Name", new string[] {
                        "CleanupCertificatesOnError"});
#line 34
  this.ScenarioSetup(scenarioInfo);
#line 35
    testRunner.Given("the certificate \'rpstsCertificate.pfx\' has been loaded using password \'abc123\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 36
   testRunner.And("place it into the \'My\' store for the \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
   testRunner.And("the certificate \'rpCertificate.pfx\' has been loaded using password \'abc123\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 38
   testRunner.And("place it into the \'My\' store for the \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 39
 testRunner.When("I create a certificate repository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 40
   testRunner.And("set the Store Name to \'My\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 41
   testRunner.And("set the Store Location to \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 42
   testRunner.And("I call FindBySubjectName with subject \'RP\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 43
    testRunner.Then("there should be \'2\' or more certificates in the collection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 44
   testRunner.And("one certificate retrieved should match the thumbprint \'0BF2B563528296FB66D4AD9452" +
                    "3648281D419078\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 45
   testRunner.And("one certificate retrieved should match the thumbprint \'66EF82D22C40F9A2576117C6BB" +
                    "69971348694AA1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.Then("any certificates should be cleaned up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Read certificate from the certificate store by thumbprint")]
        [NUnit.Framework.CategoryAttribute("CleanupCertificatesOnError")]
        public virtual void ReadCertificateFromTheCertificateStoreByThumbprint()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Read certificate from the certificate store by thumbprint", new string[] {
                        "CleanupCertificatesOnError"});
#line 49
  this.ScenarioSetup(scenarioInfo);
#line 50
    testRunner.Given("the certificate \'sampleCertificate.pfx\' has been loaded using password \'abc123\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 51
   testRunner.And("place it into the \'My\' store for the \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 52
 testRunner.When("I create a certificate repository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 53
   testRunner.And("set the Store Name to \'My\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
   testRunner.And("set the Store Location to \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 55
   testRunner.And("I call FindByThumbprint with thumbprint \'EFFF7FD55F1F37B67CCE6F539071AD13A4BFA92C" +
                    "\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 56
 testRunner.Then("one certificate retrieved should match the thumbprint \'EFFF7FD55F1F37B67CCE6F5390" +
                    "71AD13A4BFA92C\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 57
 testRunner.Then("any certificates should be cleaned up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Access two out of three certificates from My store by Subject Name")]
        [NUnit.Framework.CategoryAttribute("CleanupCertificatesOnError")]
        public virtual void AccessTwoOutOfThreeCertificatesFromMyStoreBySubjectName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Access two out of three certificates from My store by Subject Name", new string[] {
                        "CleanupCertificatesOnError"});
#line 60
  this.ScenarioSetup(scenarioInfo);
#line 61
    testRunner.Given("the certificate \'sampleCertificate.pfx\' has been loaded using password \'abc123\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 62
   testRunner.And("place it into the \'My\' store for the \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
   testRunner.And("the certificate \'additionalCertificate.pfx\' has been loaded using password \'abc12" +
                    "3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 64
   testRunner.And("place it into the \'My\' store for the \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 65
   testRunner.And("the certificate \'singleCertificate.pfx\' has been loaded using password \'abc123\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 66
   testRunner.And("place it into the \'My\' store for the \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 67
 testRunner.When("I create a certificate repository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 68
   testRunner.And("set the Store Name to \'My\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 69
   testRunner.And("set the Store Location to \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 70
   testRunner.And("I call FindBySubjectName with subject \'Sample Certificate\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 71
    testRunner.Then("there should be \'2\' certificates in the collection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 72
   testRunner.And("one certificate retrieved should match the thumbprint \'C21B70C4DA42C98C8C696A7820" +
                    "16585B5BF5223D\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 73
   testRunner.And("one certificate retrieved should match the thumbprint \'EFFF7FD55F1F37B67CCE6F5390" +
                    "71AD13A4BFA92C\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 74
 testRunner.Then("any certificates should be cleaned up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Access single certificate from My store by Subject Distinguished Name")]
        [NUnit.Framework.CategoryAttribute("CleanupCertificatesOnError")]
        public virtual void AccessSingleCertificateFromMyStoreBySubjectDistinguishedName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Access single certificate from My store by Subject Distinguished Name", new string[] {
                        "CleanupCertificatesOnError"});
#line 77
  this.ScenarioSetup(scenarioInfo);
#line 78
    testRunner.Given("the certificate \'singleCertificate.pfx\' has been loaded using password \'abc123\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 79
   testRunner.And("place it into the \'My\' store for the \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 80
 testRunner.When("I create a certificate repository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 81
   testRunner.And("set the Store Name to \'My\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
   testRunner.And("set the Store Location to \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
   testRunner.And("I call FindBySubjectDistinguishedName with subject \'CN=Single Certificate\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 84
    testRunner.Then("there should only be \'1\' certificate in the collection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 85
   testRunner.And("one certificate retrieved should match the thumbprint \'B0B7EEEA3EB2F7A927EB1B075B" +
                    "A6EF9906D928AE\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 86
 testRunner.Then("any certificates should be cleaned up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Access two certificates from My store by Subject Distinguished Name")]
        [NUnit.Framework.CategoryAttribute("CleanupCertificatesOnError")]
        public virtual void AccessTwoCertificatesFromMyStoreBySubjectDistinguishedName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Access two certificates from My store by Subject Distinguished Name", new string[] {
                        "CleanupCertificatesOnError"});
#line 89
  this.ScenarioSetup(scenarioInfo);
#line 90
    testRunner.Given("the certificate \'sampleCertificate.pfx\' has been loaded using password \'abc123\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 91
   testRunner.And("place it into the \'My\' store for the \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 92
   testRunner.And("the certificate \'additionalCertificate.pfx\' has been loaded using password \'abc12" +
                    "3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 93
   testRunner.And("place it into the \'My\' store for the \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 94
 testRunner.When("I create a certificate repository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 95
   testRunner.And("set the Store Name to \'My\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 96
   testRunner.And("set the Store Location to \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 97
   testRunner.And("I call FindBySubjectDistinguishedName with subject \'CN=Sample Certificate\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 98
    testRunner.Then("there should be \'2\' certificates in the collection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 99
   testRunner.And("one certificate retrieved should match the thumbprint \'C21B70C4DA42C98C8C696A7820" +
                    "16585B5BF5223D\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 100
   testRunner.And("one certificate retrieved should match the thumbprint \'EFFF7FD55F1F37B67CCE6F5390" +
                    "71AD13A4BFA92C\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 101
 testRunner.Then("any certificates should be cleaned up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Access two out of three certificates from My store by Subject Distinguished Name")]
        [NUnit.Framework.CategoryAttribute("CleanupCertificatesOnError")]
        public virtual void AccessTwoOutOfThreeCertificatesFromMyStoreBySubjectDistinguishedName()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Access two out of three certificates from My store by Subject Distinguished Name", new string[] {
                        "CleanupCertificatesOnError"});
#line 104
  this.ScenarioSetup(scenarioInfo);
#line 105
    testRunner.Given("the certificate \'sampleCertificate.pfx\' has been loaded using password \'abc123\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 106
   testRunner.And("place it into the \'My\' store for the \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 107
   testRunner.And("the certificate \'additionalCertificate.pfx\' has been loaded using password \'abc12" +
                    "3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 108
   testRunner.And("place it into the \'My\' store for the \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 109
   testRunner.And("the certificate \'singleCertificate.pfx\' has been loaded using password \'abc123\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 110
   testRunner.And("place it into the \'My\' store for the \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 111
 testRunner.When("I create a certificate repository", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 112
   testRunner.And("set the Store Name to \'My\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 113
   testRunner.And("set the Store Location to \'CurrentUser\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 114
   testRunner.And("I call FindBySubjectDistinguishedName with subject \'CN=Sample Certificate\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 115
    testRunner.Then("there should be \'2\' certificates in the collection", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 116
   testRunner.And("one certificate retrieved should match the thumbprint \'C21B70C4DA42C98C8C696A7820" +
                    "16585B5BF5223D\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 117
   testRunner.And("one certificate retrieved should match the thumbprint \'EFFF7FD55F1F37B67CCE6F5390" +
                    "71AD13A4BFA92C\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 118
 testRunner.Then("any certificates should be cleaned up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion

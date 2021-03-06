﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace eFormShared
{
    #region Template_Dto
    public class Template_Dto
    {
        #region con
        public Template_Dto()
        {

        }

        public Template_Dto(int id, DateTime? createdAt, DateTime? updatedAt, string label, string description, int repeated, string folderName, string workflowState, List<SiteName_Dto> deployedSites, bool hasCases, int? displayIndex)
        {
            Id = id;
            Label = label;
            Description = description;
            Repeated = repeated;
            FolderName = folderName;
            WorkflowState = workflowState;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            DeployedSites = deployedSites;
            HasCases = hasCases;
            DisplayIndex = displayIndex;
        }



        public Template_Dto(int id, DateTime? createdAt, DateTime? updatedAt, string label, string description, int repeated, string folderName, string workflowState, List<SiteName_Dto> deployedSites, bool hasCases, int? displayIndex, int? field_1, int? field_2, int? field_3, int? field_4, int? field_5, int? field_6, int? field_7, int? field_8, int? field_9, int? field_10)
        {
            Id = id;
            Label = label;
            Description = description;
            Repeated = repeated;
            FolderName = folderName;
            WorkflowState = workflowState;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
            DeployedSites = deployedSites;
            HasCases = hasCases;
            DisplayIndex = displayIndex;
            Field1 = field_1;
            Field2 = field_2;
            Field3 = field_3;
            Field4 = field_4;
            Field5 = field_5;
            Field6 = field_6;
            Field7 = field_7;
            Field8 = field_8;
            Field9 = field_9;
            Field10 = field_10;
        }
        #endregion

        #region var
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; }

        /// <summary>
        ///...
        /// </summary>
        public DateTime? CreatedAt { get; }

        /// <summary>
        ///...
        /// </summary>
        public DateTime? UpdatedAt { get; }

        /// <summary>
        /// Label
        /// </summary>
        public string Label { get; }

        /// <summary>
        /// Descrition
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Repeated
        /// </summary>
        public int Repeated { get; }

        /// <summary>
        /// FolderName
        /// </summary>
        public string FolderName { get; }

        /// <summary>
        /// WorkflowState
        /// </summary>
        public string WorkflowState { get; }

        /// <summary>
        /// WorkflowState
        /// </summary>
        public List<SiteName_Dto> DeployedSites { get; }

        /// <summary>
        /// WorkflowState
        /// </summary>
        public bool HasCases { get; }

        /// <summary>
        /// DiplayIndex
        /// </summary>
        public int? DisplayIndex { get; }

        /// <summary>
        /// Field1
        /// </summary>
        public int? Field1 { get; }

        /// <summary>
        /// Field2
        /// </summary>
        public int? Field2 { get; }

        /// <summary>
        /// Field3
        /// </summary>
        public int? Field3 { get; }

        /// <summary>
        /// Field4
        /// </summary>
        public int? Field4 { get; }

        /// <summary>
        /// Field5
        /// </summary>
        public int? Field5 { get; }

        /// <summary>
        /// Field6
        /// </summary>
        public int? Field6 { get; }

        /// <summary>
        /// Field7
        /// </summary>
        public int? Field7 { get; }

        /// <summary>
        /// Field8
        /// </summary>
        public int? Field8 { get; }

        /// <summary>
        /// Field9
        /// </summary>
        public int? Field9 { get; }

        /// <summary>
        /// Field10
        /// </summary>
        public int? Field10 { get; }
        #endregion
    }
    #endregion

    #region Field_Dto
    public class Field_Dto
    {
        #region con
        public Field_Dto()
        {

        }

        public Field_Dto(int id, string label, string description, int fieldTypeId, string fieldType)
        {
            Id = id;
            Label = label;
            Description = description;
            FieldTypeId = fieldTypeId;
            FieldType = fieldType;
        }
        #endregion

        #region var
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Label
        /// </summary>
        public string Label { get; }

        /// <summary>
        /// Descrition
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Repeated
        /// </summary>
        public int FieldTypeId { get; }

        /// <summary>
        /// Descrition
        /// </summary>
        public string FieldType { get; }

        #endregion
    }
    #endregion

    #region Case
    public class Case
    {
        public int Id { get; set; }

        public string WorkflowState { get; set; }

        public int? Version { get; set; }

        public int? Status { get; set; }

        public DateTime? CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public DateTime? DoneAt { get; set; }

        public int? SiteId { get; set; }

        public string SiteName { get; set; }

        public int? UnitId { get; set; }

        public string WorkerName { get; set; }

        public int? TemplatId { get; set; }

        public string CaseType { get; set; }

        public string MicrotingUId { get; set; }

        public string CheckUIid { get; set; }

        public string CaseUId { get; set; }

        public string Custom { get; set; }

        public string FieldValue1 { get; set; }

        public string FieldValue2 { get; set; }

        public string FieldValue3 { get; set; }

        public string FieldValue4 { get; set; }

        public string FieldValue5 { get; set; }

        public string FieldValue6 { get; set; }

        public string FieldValue7 { get; set; }

        public string FieldValue8 { get; set; }

        public string FieldValue9 { get; set; }

        public string FieldValue10 { get; set; }
    }
    #endregion

    #region Case_Dto
    public class Case_Dto
    {
        #region con
        public Case_Dto()
        {
        }

        public Case_Dto(int? caseId, string stat, int siteUId, string caseType, string caseUId, string microtingUId, string checkUId, string custom, int checkListId)
        {
            if (caseType == null)
                caseType = "";
            if (caseUId == null)
                caseUId = "";
            if (microtingUId == null)
                microtingUId = "";
            if (checkUId == null)
                checkUId = "";

            CaseId = caseId;
            Stat = stat;
            SiteUId = siteUId;
            CaseType = caseType;
            CaseUId = caseUId;
            MicrotingUId = microtingUId;
            CheckUId = checkUId;
            Custom = custom;
            CheckListId = checkListId;
        }

        #endregion

        #region var
        /// <summary>
        /// Local case identifier
        /// </summary>
        public int? CaseId { get; }

        /// <summary>
        /// Status of the case
        /// </summary>
        public string Stat { get; }

        /// <summary>
        /// Unique identifier of device
        /// </summary>
        public int SiteUId { get; }

        /// <summary>
        /// Identifier of a collection of cases in your system
        /// </summary>
        public string CaseType { get; }

        /// <summary>
        /// Unique identifier of a group of case(s) in your system
        /// </summary>
        public string CaseUId { get; }

        /// <summary>
        ///Unique identifier of that specific eForm in Microting system
        /// </summary>
        public string MicrotingUId { get; }

        /// <summary>
        /// Unique identifier of that check of the eForm. Only used if repeat
        /// </summary>
        public string CheckUId { get; }

        /// <summary>
        /// Custom data. Only used in special cases
        /// </summary>
        public string Custom { get; }

        /// <summary>
        /// Unique identifier of device
        /// </summary>
        public int CheckListId { get; }

        #endregion

        public override string ToString()
        {
            string caseIdStr;

            if (CaseId == null)
                caseIdStr = "";
            else
                caseIdStr = CaseId.ToString();

            if (CheckUId == null) return "CaseId:" + caseIdStr + " / Stat:" + Stat + " / SiteUId:" + SiteUId + " / CaseType:" + CaseType + " / CaseUId:" + CaseUId + " / MicrotingUId:" + MicrotingUId + ".";
            if (CheckUId == "")   return "CaseId:" + caseIdStr + " / Stat:" + Stat + " / SiteUId:" + SiteUId + " / CaseType:" + CaseType + " / CaseUId:" + CaseUId + " / MicrotingUId:" + MicrotingUId + ".";
                                  return "CaseId:" + caseIdStr + " / Stat:" + Stat + " / SiteUId:" + SiteUId + " / CaseType:" + CaseType + " / CaseUId:" + CaseUId + " / MicrotingUId:" + MicrotingUId + " / CheckId:" + CheckUId + ".";
        }
    }
    #endregion

    #region File_Dto
    public class File_Dto
    {
        #region con
        public File_Dto(int siteUId, string caseType, string caseUId, string microtingUId, string checkUId, string fileLocation)
        {
            if (caseType == null)
                caseType = "";
            if (caseUId == null)
                caseUId = "";
            if (microtingUId == null)
                microtingUId = "";
            if (checkUId == null)
                checkUId = "";
            if (fileLocation == null)
                fileLocation = "";

            SiteUId = siteUId;
            CaseType = caseType;
            CaseUId = caseUId;
            MicrotingUId = microtingUId;
            CheckUId = checkUId;
            FileLocation = fileLocation;
        }
        #endregion

        #region var
        /// <summary>
        /// Unique identifier of device
        /// </summary>
        public int SiteUId { get; }

        /// <summary>
        /// Identifier of a collection of cases in your system
        /// </summary>
        public string CaseType { get; }

        /// <summary>
        /// Unique identifier of a group of case(s) in your system
        /// </summary>
        public string CaseUId { get; }

        /// <summary>
        ///Unique identifier of that specific eForm in Microting system
        /// </summary>
        public string MicrotingUId { get; }

        /// <summary>
        /// Unique identifier of that check of the eForm. Only used if repeat
        /// </summary>
        public string CheckUId { get; }

        /// <summary>
        /// Location of the fil
        /// </summary>
        public string FileLocation { get; set; }
        #endregion

        public override string ToString()
        {
            return "SiteUId:" + SiteUId + " / CaseType:" + CaseType + " / CaseUId:" + CaseUId + " / MicrotingUId:" + MicrotingUId + " / CheckId:" + CheckUId + " / FileLocation:" + FileLocation;
        }
    }
    #endregion

    #region Site_Dto
    public class Site_Dto
    {
        #region con
        public Site_Dto()
        {
        }

        public Site_Dto(int siteId, string siteName, string userFirstName, string userLastName, int? customerNo, int? otpCode, int? unitId, int? workerUid)
        {
            if (siteName == null)
                siteName = "";
            if (userFirstName == null)
                userFirstName = "";
            if (userLastName == null)
                userLastName = "";

            SiteId = siteId;
            SiteName = siteName;
            FirstName = userFirstName;
            LastName = userLastName;
            CustomerNo = customerNo;
            OtpCode = otpCode;
            UnitId = unitId;
            WorkerUid = workerUid;
        }
        #endregion

        #region var
        /// <summary>
        ///...
        /// </summary>
        public int SiteId { get; }

        /// <summary>
        ///...
        /// </summary>
        public string SiteName { get; }

        /// <summary>
        ///...
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        ///...
        /// </summary>
        public string LastName { get; }

        /// <summary>
        ///...
        /// </summary>
        public int? CustomerNo { get; }

        /// <summary>
        ///...
        /// </summary>
        public int? OtpCode { get; }

        /// <summary>
        ///...
        /// </summary>
        public int? UnitId { get; }

        /// <summary>
        ///...
        /// </summary>
        public int? WorkerUid { get; }
        #endregion

        public override string ToString()
        {
            return "SiteId:" + SiteId + " / SiteName:" + SiteName + " / FirstName:" + FirstName + " / LastName:" + LastName + " / CustomerNo:" + CustomerNo + " / OtpCode:" + OtpCode + "UnitId:" + UnitId + "WorkerUid:" + WorkerUid + ".";
        }
    }
    #endregion

    #region Note_Dto
    public class Note_Dto
    {
        #region con
        public Note_Dto()
        {

        }

        public Note_Dto(string id, string microtingUId, string activity)
        {
            Id = id;
            MicrotingUId = microtingUId;
            Activity = activity;
        }
        #endregion

        #region var
        public string Id { get; }

        public string MicrotingUId { get; }

        public string Activity { get; }
        #endregion

        public override string ToString()
        {
            return "Id:" + Id + " / MicrotingUId:" + MicrotingUId + " / Activity:" + Activity + ".";
        }
    }
    #endregion

    #region SiteName_Dto
    public class SiteName_Dto
    {
        #region con
        public SiteName_Dto()
        {
        }

        public SiteName_Dto(int siteUId, string siteName, DateTime? createdAt, DateTime? updatedAt)
        {
            if (siteName == null)
                siteName = "";

            SiteUId = siteUId;
            SiteName = siteName;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
        #endregion

        #region var
        /// <summary>
        ///...
        /// </summary>
        public int SiteUId { get; }

        /// <summary>
        ///...
        /// </summary>
        public string SiteName { get; }

        /// <summary>
        ///...
        /// </summary>
        public DateTime? CreatedAt { get; }

        /// <summary>
        ///...
        /// </summary>
        public DateTime? UpdatedAt { get; }

        #endregion

        public override string ToString()
        {
            return "SiteUId:" + SiteUId + " / SiteName:" + SiteName + " / CreatedAt:" + CreatedAt + " / UpdatedAt:" + UpdatedAt + ".";
        }
    }
    #endregion

    #region Worker_Dto
    public class Worker_Dto
    {
        #region con
        public Worker_Dto()
        {
        }

        public Worker_Dto(int workerUId, string firstName, string lastName, string email, DateTime? createdAt, DateTime? updatedAt)
        {
            if (firstName == null)
                firstName = "";

            if (lastName == null)
                lastName = "";

            if (email == null)
                email = "";

            WorkerUId = workerUId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
        #endregion

        #region var
        /// <summary>
        ///...
        /// </summary>
        public int WorkerUId { get; }

        /// <summary>
        ///...
        /// </summary>
        public string FirstName { get; }

        /// <summary>
        ///...
        /// </summary>
        public string LastName { get; }

        /// <summary>
        ///...
        /// </summary>
        public string Email { get; }

        /// <summary>
        ///...
        /// </summary>
        public DateTime? CreatedAt { get; }

        /// <summary>
        ///...
        /// </summary>
        public DateTime? UpdatedAt { get; }

        #endregion

        public override string ToString()
        {
            return "WorkerUId:" + WorkerUId + " / FirstName:" + FirstName + " / LastName:" + LastName + " / Email:" + Email + " / CreatedAt:" + CreatedAt + " / UpdatedAt:" + UpdatedAt + ".";
        }
    }
    #endregion

    #region Site_Worker_Dto
    public class Site_Worker_Dto
    {
        #region con
        public Site_Worker_Dto()
        {
        }

        public Site_Worker_Dto(int microtingUId, int siteUId, int workerUId)
        {
            MicrotingUId = microtingUId;
            SiteUId = siteUId;
            WorkerUId = workerUId;
        }
        #endregion

        #region var
        /// <summary>
        ///...
        /// </summary>
        public int MicrotingUId { get; }

        /// <summary>
        ///...
        /// </summary>
        public int SiteUId { get; }

        /// <summary>
        ///...
        /// </summary>
        public int WorkerUId { get; }

        #endregion

        public override string ToString()
        {
            return "MicrotingUId:" + MicrotingUId + " / SiteUId:" + SiteUId + " / WorkerUId:" + WorkerUId + ".";
        }
    }
    #endregion

    #region Unit_Dto
    public class Unit_Dto
    {
        #region con
        public Unit_Dto()
        {
        }

        public Unit_Dto(int unitUId, int customerNo, int otpCode, int siteUId, DateTime? createdAt, DateTime? updatedAt)
        {
            UnitUId = unitUId;
            CustomerNo = customerNo;
            OtpCode = otpCode;
            SiteUId = siteUId;
            CreatedAt = createdAt;
            UpdatedAt = updatedAt;
        }
        #endregion

        #region var
        /// <summary>
        ///...
        /// </summary>
        public int UnitUId { get; }

        /// <summary>
        ///...
        /// </summary>
        public int CustomerNo { get; }

        /// <summary>
        ///...
        /// </summary>
        public int OtpCode { get; }

        /// <summary>
        ///...
        /// </summary>
        public int SiteUId { get; }

        /// <summary>
        ///...
        /// </summary>
        public DateTime? CreatedAt { get; }

        /// <summary>
        ///...
        /// </summary>
        public DateTime? UpdatedAt { get; }

        #endregion

        public override string ToString()
        {
            return "UnitUId:" + UnitUId + " / CustomerNo:" + CustomerNo + " / OtpCode:" + OtpCode + " / SiteUId:" + SiteUId + " / CreatedAt:" + CreatedAt + " / UpdatedAt:" + UpdatedAt + ".";
        }
    }
    #endregion

    #region Organization_Dto
    public class Organization_Dto
    {
        #region con
        public Organization_Dto()
        {

        }

        public Organization_Dto(int id, string name, int customerNo, int unitLicenseNumber, string awsAccessKeyId, string awsSecretAccessKey, string awsEndPoint, string comAddress, string comAddressBasic, string comAddressPdfUpload)
        {
            Id = id;
            Name = name;
            CustomerNo = customerNo;
            UnitLicenseNumber = unitLicenseNumber;
            AwsAccessKeyId = awsAccessKeyId;
            AwsSecretAccessKey = awsSecretAccessKey;
            AwsEndPoint = awsEndPoint;
            ComAddressApi = comAddress;
            ComAddressBasic = comAddressBasic;
            ComAddressPdfUpload = comAddressPdfUpload;
        }
        #endregion

        #region var
        public int Id { get; }
        public string Name { get; }
        public int CustomerNo { get; }
        public int UnitLicenseNumber { get; }
        public string AwsAccessKeyId { get; }
        public string AwsSecretAccessKey { get; }
        public string AwsEndPoint { get; }
        public string ComAddressApi { get; }
        public string ComAddressBasic { get; }
        public string ComAddressPdfUpload { get; }
        #endregion

        public override string ToString()
        {
            return "OrganizationUid:" + Id + " / Name:" + Name + " / CustomerNo:" + CustomerNo + " / UnitLicenseNumber:" + UnitLicenseNumber
                + " / AwsAccessKeyId:" + AwsAccessKeyId + " / AwsSecretAccessKey:" + AwsSecretAccessKey + " / AwsEndPoint:" + AwsEndPoint
                + " / ComAddress:" + ComAddressApi + " / ComAddressBasic:" + ComAddressBasic + " / ComAddressPdfUpload:" + ComAddressPdfUpload + ".";
        }
    }
    #endregion

    #region Holder
    public class Holder
    {
        public Holder(int index, string field_type)
        {
            Index = index;
            FieldType = field_type;
        }

        public int Index { get; }

        public string FieldType { get; }
    }
    #endregion

    #region EntityItemUpdateInfo
    public class EntityItemUpdateInfo
    {
        public EntityItemUpdateInfo(string entityItemMUid, string status)
        {
            EntityItemMUid = entityItemMUid;
            Status = status;
        }

        public string EntityItemMUid { get; set; }
        public string Status { get; set; }
    }
    #endregion

    #region KeyValuePair
    [Serializable()]
    public class KeyValuePair
    {
        #region con
        internal KeyValuePair()
        {

        }

        public KeyValuePair(string key, string value, bool selected, string displayOrder)
        {
            Key = key;
            Value = value;
            Selected = selected;
            DisplayOrder = displayOrder;
        }
        #endregion

        #region var
        public string Key { get; set; }
        public string Value { get; set; }
        public bool Selected { get; set; }
        public string DisplayOrder { get; set; }
        #endregion
    }
    #endregion

    #region CDataValue
    public class CDataValue
    {
        [XmlIgnore]
        public string InderValue { get; set; }

        [XmlText]
        public XmlNode[] CDataWrapper
        {
            get
            {
                var dummy = new XmlDocument();
                return new XmlNode[] { dummy.CreateCDataSection(InderValue) };
            }
            set
            {
                if (value == null)
                {
                    InderValue = null;
                    return;
                }

                if (value.Length != 1)
                {
                    throw new InvalidOperationException(
                        String.Format(
                            "Invalid array length {0}", value.Length));
                }

                InderValue = value[0].Value;
            }
        }
    }
    #endregion

    #region ExceptionClass
    public class ExceptionClass
    {
        private ExceptionClass()
        {

        }

        public ExceptionClass(string description, DateTime time)
        {
            Description = description;
            Time = time;
        }

        public string Description { get; set; }
        public DateTime Time { get; set; }
    }
    #endregion
}
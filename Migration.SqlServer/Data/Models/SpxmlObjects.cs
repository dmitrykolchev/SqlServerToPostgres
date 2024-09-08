using System;
using System.Collections.Generic;

namespace Migration.SqlServer.Data.Models;

public partial class SpxmlObjects
{
    public long Id { get; set; }

    public string? Form { get; set; }

    public string? SpxmlForm { get; set; }

    public byte? IsDeleted { get; set; }

    public DateTime? Modified { get; set; }

    public virtual Account? Account { get; set; }

    public virtual Acquaint? Acquaint { get; set; }

    public virtual AcquaintAssign? AcquaintAssign { get; set; }

    public virtual ActionReport? ActionReport { get; set; }

    public virtual ActiveLearning? ActiveLearning { get; set; }

    public virtual ActiveNotification? ActiveNotification { get; set; }

    public virtual ActiveTestLearning? ActiveTestLearning { get; set; }

    public virtual ActiveWebTemplate? ActiveWebTemplate { get; set; }

    public virtual Activity? Activity { get; set; }

    public virtual ActivityState? ActivityState { get; set; }

    public virtual Article? Article { get; set; }

    public virtual Assessment? Assessment { get; set; }

    public virtual AssessmentAppraise? AssessmentAppraise { get; set; }

    public virtual AssessmentAppraiseMatrix? AssessmentAppraiseMatrix { get; set; }

    public virtual AssessmentPlan? AssessmentPlan { get; set; }

    public virtual AssessmentResultRecommend? AssessmentResultRecommend { get; set; }

    public virtual AvailabilityPlan? AvailabilityPlan { get; set; }

    public virtual Banner? Banner { get; set; }

    public virtual Basket? Basket { get; set; }

    public virtual Benefit? Benefit { get; set; }

    public virtual BenefitItem? BenefitItem { get; set; }

    public virtual Blog? Blog { get; set; }

    public virtual BlogEntry? BlogEntry { get; set; }

    public virtual BlogEntryComment? BlogEntryComment { get; set; }

    public virtual BonusItem? BonusItem { get; set; }

    public virtual BonusProfile? BonusProfile { get; set; }

    public virtual Book? Book { get; set; }

    public virtual BossType? BossType { get; set; }

    public virtual Bp? Bp { get; set; }

    public virtual BpRole? BpRole { get; set; }

    public virtual Budget? Budget { get; set; }

    public virtual BudgetPeriod? BudgetPeriod { get; set; }

    public virtual BudgetType? BudgetType { get; set; }

    public virtual CandidateSource? CandidateSource { get; set; }

    public virtual CandidateStatusType? CandidateStatusType { get; set; }

    public virtual CareerReserve? CareerReserve { get; set; }

    public virtual CareerReserveType? CareerReserveType { get; set; }

    public virtual CcAccessDivison? CcAccessDivison { get; set; }

    public virtual CcAccessElement? CcAccessElement { get; set; }

    public virtual CcAccessPeriod? CcAccessPeriod { get; set; }

    public virtual CcAccessTemplate? CcAccessTemplate { get; set; }

    public virtual CcAppCourse? CcAppCourse { get; set; }

    public virtual CcAttestation? CcAttestation { get; set; }

    public virtual CcCollaborator? CcCollaborator { get; set; }

    public virtual CcContragentImport? CcContragentImport { get; set; }

    public virtual CcCostHistory? CcCostHistory { get; set; }

    public virtual CcCourseDate? CcCourseDate { get; set; }

    public virtual CcCourseOrg? CcCourseOrg { get; set; }

    public virtual CcDirect? CcDirect { get; set; }

    public virtual CcDocField? CcDocField { get; set; }

    public virtual CcDocSetting? CcDocSetting { get; set; }

    public virtual CcEditLog? CcEditLog { get; set; }

    public virtual CcEduField? CcEduField { get; set; }

    public virtual CcEduFieldType? CcEduFieldType { get; set; }

    public virtual CcEduOrgCode? CcEduOrgCode { get; set; }

    public virtual CcEduTheme? CcEduTheme { get; set; }

    public virtual CcEduType? CcEduType { get; set; }

    public virtual CcEduapp? CcEduapp { get; set; }

    public virtual CcEducation? CcEducation { get; set; }

    public virtual CcEdufieldApp? CcEdufieldApp { get; set; }

    public virtual CcEventPresence? CcEventPresence { get; set; }

    public virtual CcEventTheme? CcEventTheme { get; set; }

    public virtual CcEventThemeCompl? CcEventThemeCompl { get; set; }

    public virtual CcFlow? CcFlow { get; set; }

    public virtual CcGroupCount? CcGroupCount { get; set; }

    public virtual CcIndProgramTheme? CcIndProgramTheme { get; set; }

    public virtual CcInoutControl? CcInoutControl { get; set; }

    public virtual CcKcPerson? CcKcPerson { get; set; }

    public virtual CcKnowledgeClassifier? CcKnowledgeClassifier { get; set; }

    public virtual CcLocalStorage? CcLocalStorage { get; set; }

    public virtual CcLogExport? CcLogExport { get; set; }

    public virtual CcLogImport? CcLogImport { get; set; }

    public virtual CcOrg? CcOrg { get; set; }

    public virtual CcOssImport? CcOssImport { get; set; }

    public virtual CcPeriodType? CcPeriodType { get; set; }

    public virtual CcPfoAssessmentCriteria? CcPfoAssessmentCriteria { get; set; }

    public virtual CcPfoDiv? CcPfoDiv { get; set; }

    public virtual CcPfoGrafic? CcPfoGrafic { get; set; }

    public virtual CcPfoMethod? CcPfoMethod { get; set; }

    public virtual CcPfoMethodResult? CcPfoMethodResult { get; set; }

    public virtual CcPfoMethodScale? CcPfoMethodScale { get; set; }

    public virtual CcPfoPassword? CcPfoPassword { get; set; }

    public virtual CcPfoPoll? CcPfoPoll { get; set; }

    public virtual CcPfoPollProcedure? CcPfoPollProcedure { get; set; }

    public virtual CcPfoPollResult? CcPfoPollResult { get; set; }

    public virtual CcPfoPositionGroup? CcPfoPositionGroup { get; set; }

    public virtual CcPfoQualCourseOrder? CcPfoQualCourseOrder { get; set; }

    public virtual CcPfoQualificationCourse? CcPfoQualificationCourse { get; set; }

    public virtual CcPfoQualificationPosition? CcPfoQualificationPosition { get; set; }

    public virtual CcPfoRequest? CcPfoRequest { get; set; }

    public virtual CcPfoRequestMethod? CcPfoRequestMethod { get; set; }

    public virtual CcPfoRequestToLearning? CcPfoRequestToLearning { get; set; }

    public virtual CcPfoRequestTransfer? CcPfoRequestTransfer { get; set; }

    public virtual CcPfoResultGroup? CcPfoResultGroup { get; set; }

    public virtual CcPfoScaleResult? CcPfoScaleResult { get; set; }

    public virtual CcPmtoNppBlock? CcPmtoNppBlock { get; set; }

    public virtual CcPmtoObservation? CcPmtoObservation { get; set; }

    public virtual CcPmtoObservationDirector? CcPmtoObservationDirector { get; set; }

    public virtual CcPmtoObservationEmployee? CcPmtoObservationEmployee { get; set; }

    public virtual CcPmtoObservationResult? CcPmtoObservationResult { get; set; }

    public virtual CcPmtoObservationSpecialist? CcPmtoObservationSpecialist { get; set; }

    public virtual CcPmtoPosition? CcPmtoPosition { get; set; }

    public virtual CcPmtoPositionShort? CcPmtoPositionShort { get; set; }

    public virtual CcPmtoShift? CcPmtoShift { get; set; }

    public virtual CcPollProcedure? CcPollProcedure { get; set; }

    public virtual CcPrevWork? CcPrevWork { get; set; }

    public virtual CcProgramDate? CcProgramDate { get; set; }

    public virtual CcQualification? CcQualification { get; set; }

    public virtual CcQuiz? CcQuiz { get; set; }

    public virtual CcRejectReason? CcRejectReason { get; set; }

    public virtual CcReqDateHistory? CcReqDateHistory { get; set; }

    public virtual CcRequestReason? CcRequestReason { get; set; }

    public virtual CcResultHistory? CcResultHistory { get; set; }

    public virtual CcRtn? CcRtn { get; set; }

    public virtual CcRtnActivity? CcRtnActivity { get; set; }

    public virtual CcRtnApplication? CcRtnApplication { get; set; }

    public virtual CcRtnApplicationType? CcRtnApplicationType { get; set; }

    public virtual CcRtnControlKind? CcRtnControlKind { get; set; }

    public virtual CcRtnControlResultType? CcRtnControlResultType { get; set; }

    public virtual CcRtnControlType? CcRtnControlType { get; set; }

    public virtual CcRtnDuty? CcRtnDuty { get; set; }

    public virtual CcRtnExamMedical? CcRtnExamMedical { get; set; }

    public virtual CcRtnExamPsychical? CcRtnExamPsychical { get; set; }

    public virtual CcRtnFault? CcRtnFault { get; set; }

    public virtual CcRtnKnowledge? CcRtnKnowledge { get; set; }

    public virtual CcRtnKnowledgeSafety? CcRtnKnowledgeSafety { get; set; }

    public virtual CcRtnKnowledgeTheory? CcRtnKnowledgeTheory { get; set; }

    public virtual CcRtnLicense? CcRtnLicense { get; set; }

    public virtual CcRtnLicense2? CcRtnLicense2 { get; set; }

    public virtual CcRtnLicenseActivity? CcRtnLicenseActivity { get; set; }

    public virtual CcRtnLicenseActivityResult? CcRtnLicenseActivityResult { get; set; }

    public virtual CcRtnLicenseControl? CcRtnLicenseControl { get; set; }

    public virtual CcRtnLicenseControlResult? CcRtnLicenseControlResult { get; set; }

    public virtual CcRtnLicenseDoubling? CcRtnLicenseDoubling { get; set; }

    public virtual CcRtnLicenseFault? CcRtnLicenseFault { get; set; }

    public virtual CcRtnLicenseHolder? CcRtnLicenseHolder { get; set; }

    public virtual CcRtnLicenseHolderType? CcRtnLicenseHolderType { get; set; }

    public virtual CcRtnLicensePerm? CcRtnLicensePerm { get; set; }

    public virtual CcRtnLicensePermState? CcRtnLicensePermState { get; set; }

    public virtual CcRtnLicensePost? CcRtnLicensePost { get; set; }

    public virtual CcRtnLicensePost2? CcRtnLicensePost2 { get; set; }

    public virtual CcRtnLicensePostHistory? CcRtnLicensePostHistory { get; set; }

    public virtual CcRtnLicensePrepareState? CcRtnLicensePrepareState { get; set; }

    public virtual CcRtnLicenseQual? CcRtnLicenseQual { get; set; }

    public virtual CcRtnLicenseSkill? CcRtnLicenseSkill { get; set; }

    public virtual CcRtnLicenseSkillResult? CcRtnLicenseSkillResult { get; set; }

    public virtual CcRtnLicenseState? CcRtnLicenseState { get; set; }

    public virtual CcRtnLicenseTraining? CcRtnLicenseTraining { get; set; }

    public virtual CcRtnLicenseTraining2? CcRtnLicenseTraining2 { get; set; }

    public virtual CcRtnNppBlock? CcRtnNppBlock { get; set; }

    public virtual CcRtnNppBlockStage? CcRtnNppBlockStage { get; set; }

    public virtual CcRtnPermission? CcRtnPermission { get; set; }

    public virtual CcRtnPermissionStatusType? CcRtnPermissionStatusType { get; set; }

    public virtual CcRtnPermissionStop? CcRtnPermissionStop { get; set; }

    public virtual CcRtnPostApproved? CcRtnPostApproved { get; set; }

    public virtual CcRtnPostCategory? CcRtnPostCategory { get; set; }

    public virtual CcRtnPostLicensed? CcRtnPostLicensed { get; set; }

    public virtual CcRtnPostOperative? CcRtnPostOperative { get; set; }

    public virtual CcRtnPostOperativeBlock? CcRtnPostOperativeBlock { get; set; }

    public virtual CcRtnPostStation? CcRtnPostStation { get; set; }

    public virtual CcRtnPostStationActivity? CcRtnPostStationActivity { get; set; }

    public virtual CcRtnPostStationLicensed? CcRtnPostStationLicensed { get; set; }

    public virtual CcRtnPostStructure? CcRtnPostStructure { get; set; }

    public virtual CcRtnPostStructureControl? CcRtnPostStructureControl { get; set; }

    public virtual CcRtnPostSubcategory? CcRtnPostSubcategory { get; set; }

    public virtual CcRtnSkill? CcRtnSkill { get; set; }

    public virtual CcScmtAssign? CcScmtAssign { get; set; }

    public virtual CcScmtAssignAnswer? CcScmtAssignAnswer { get; set; }

    public virtual CcScmtAssignGroup? CcScmtAssignGroup { get; set; }

    public virtual CcScmtAssignGroupList? CcScmtAssignGroupList { get; set; }

    public virtual CcScmtOption? CcScmtOption { get; set; }

    public virtual CcSelftestCode? CcSelftestCode { get; set; }

    public virtual CcSelftestDb? CcSelftestDb { get; set; }

    public virtual CcSelftestExpert? CcSelftestExpert { get; set; }

    public virtual CcSelftestModel? CcSelftestModel { get; set; }

    public virtual CcSkvzActivity? CcSkvzActivity { get; set; }

    public virtual CcSkvzBpApprovedObject? CcSkvzBpApprovedObject { get; set; }

    public virtual CcSkvzCouncilMember? CcSkvzCouncilMember { get; set; }

    public virtual CcSkvzCouncilMemberDiv? CcSkvzCouncilMemberDiv { get; set; }

    public virtual CcSkvzCritPosition? CcSkvzCritPosition { get; set; }

    public virtual CcSkvzCriteriaActivity? CcSkvzCriteriaActivity { get; set; }

    public virtual CcSkvzCriticalityPosFactor? CcSkvzCriticalityPosFactor { get; set; }

    public virtual CcSkvzDiv? CcSkvzDiv { get; set; }

    public virtual CcSkvzEv? CcSkvzEv { get; set; }

    public virtual CcSkvzExtractKvzType? CcSkvzExtractKvzType { get; set; }

    public virtual CcSkvzKmap? CcSkvzKmap { get; set; }

    public virtual CcSkvzKmapItem? CcSkvzKmapItem { get; set; }

    public virtual CcSkvzKnowledgeDocsFactor? CcSkvzKnowledgeDocsFactor { get; set; }

    public virtual CcSkvzMovedStage? CcSkvzMovedStage { get; set; }

    public virtual CcSkvzPlanEv? CcSkvzPlanEv { get; set; }

    public virtual CcSkvzPlanEvEvent? CcSkvzPlanEvEvent { get; set; }

    public virtual CcSkvzPlanExtractKvz? CcSkvzPlanExtractKvz { get; set; }

    public virtual CcSkvzPlanExtractKvzExp? CcSkvzPlanExtractKvzExp { get; set; }

    public virtual CcSkvzPlanExtractKvzFile? CcSkvzPlanExtractKvzFile { get; set; }

    public virtual CcSkvzPlanExtractKvzWg? CcSkvzPlanExtractKvzWg { get; set; }

    public virtual CcSkvzPlanInstallKvz? CcSkvzPlanInstallKvz { get; set; }

    public virtual CcSkvzPollActivity? CcSkvzPollActivity { get; set; }

    public virtual CcSkvzPollActivityCr? CcSkvzPollActivityCr { get; set; }

    public virtual CcSkvzPollKvzPersonResult? CcSkvzPollKvzPersonResult { get; set; }

    public virtual CcSkvzPollSpFinalResult? CcSkvzPollSpFinalResult { get; set; }

    public virtual CcSkvzPollSpFirstCr? CcSkvzPollSpFirstCr { get; set; }

    public virtual CcSkvzPollSpFirstResult? CcSkvzPollSpFirstResult { get; set; }

    public virtual CcSkvzReadyReservFactor? CcSkvzReadyReservFactor { get; set; }

    public virtual CcSkvzRiskFreePosFactor? CcSkvzRiskFreePosFactor { get; set; }

    public virtual CcSkvzSp? CcSkvzSp { get; set; }

    public virtual CcSkvzSpActivityCr? CcSkvzSpActivityCr { get; set; }

    public virtual CcSkvzStation? CcSkvzStation { get; set; }

    public virtual CcSkvzStationBlock? CcSkvzStationBlock { get; set; }

    public virtual CcSkvzStationBlockType? CcSkvzStationBlockType { get; set; }

    public virtual CcSkvzSuccessor? CcSkvzSuccessor { get; set; }

    public virtual CcSkvzWgMember? CcSkvzWgMember { get; set; }

    public virtual CcSkvzWgMemberToType? CcSkvzWgMemberToType { get; set; }

    public virtual CcSkvzWgMemberType? CcSkvzWgMemberType { get; set; }

    public virtual CcSkvzYearPlan? CcSkvzYearPlan { get; set; }

    public virtual CcSkvzYearPlanEvent? CcSkvzYearPlanEvent { get; set; }

    public virtual CcStaffevalAgentManagment? CcStaffevalAgentManagment { get; set; }

    public virtual CcStaffevalAttestation? CcStaffevalAttestation { get; set; }

    public virtual CcStaffevalColsCategorie? CcStaffevalColsCategorie { get; set; }

    public virtual CcStaffevalCorrection? CcStaffevalCorrection { get; set; }

    public virtual CcStaffevalCorrectionDiv? CcStaffevalCorrectionDiv { get; set; }

    public virtual CcStaffevalCurator? CcStaffevalCurator { get; set; }

    public virtual CcStaffevalDirection? CcStaffevalDirection { get; set; }

    public virtual CcStaffevalDocument? CcStaffevalDocument { get; set; }

    public virtual CcStaffevalDocumentCode? CcStaffevalDocumentCode { get; set; }

    public virtual CcStaffevalEduHour? CcStaffevalEduHour { get; set; }

    public virtual CcStaffevalFile? CcStaffevalFile { get; set; }

    public virtual CcStaffevalFirstDocument? CcStaffevalFirstDocument { get; set; }

    public virtual CcStaffevalFirstQual? CcStaffevalFirstQual { get; set; }

    public virtual CcStaffevalInsPeriod? CcStaffevalInsPeriod { get; set; }

    public virtual CcStaffevalInsQualification? CcStaffevalInsQualification { get; set; }

    public virtual CcStaffevalInstructor? CcStaffevalInstructor { get; set; }

    public virtual CcStaffevalLogAgntsPerekr? CcStaffevalLogAgntsPerekr { get; set; }

    public virtual CcStaffevalLogAgntsQual? CcStaffevalLogAgntsQual { get; set; }

    public virtual CcStaffevalPgPerekrest? CcStaffevalPgPerekrest { get; set; }

    public virtual CcStaffevalPollProcedure? CcStaffevalPollProcedure { get; set; }

    public virtual CcStaffevalPollsItem? CcStaffevalPollsItem { get; set; }

    public virtual CcStaffevalPollsPUser? CcStaffevalPollsPUser { get; set; }

    public virtual CcStaffevalPollsResult? CcStaffevalPollsResult { get; set; }

    public virtual CcStaffevalPollsType? CcStaffevalPollsType { get; set; }

    public virtual CcStaffevalPosition? CcStaffevalPosition { get; set; }

    public virtual CcStaffevalPositionCa? CcStaffevalPositionCa { get; set; }

    public virtual CcStaffevalPpdCa? CcStaffevalPpdCa { get; set; }

    public virtual CcStaffevalPpdCaFirstPlan? CcStaffevalPpdCaFirstPlan { get; set; }

    public virtual CcStaffevalPpdFixedCa? CcStaffevalPpdFixedCa { get; set; }

    public virtual CcStaffevalPpdSp? CcStaffevalPpdSp { get; set; }

    public virtual CcStaffevalPpdSpFirstPlan? CcStaffevalPpdSpFirstPlan { get; set; }

    public virtual CcStaffevalPpdSpFixed? CcStaffevalPpdSpFixed { get; set; }

    public virtual CcStaffevalPpk? CcStaffevalPpk { get; set; }

    public virtual CcStaffevalPpkCa? CcStaffevalPpkCa { get; set; }

    public virtual CcStaffevalPpkSpFromCa? CcStaffevalPpkSpFromCa { get; set; }

    public virtual CcStaffevalProcessName? CcStaffevalProcessName { get; set; }

    public virtual CcStaffevalQualification? CcStaffevalQualification { get; set; }

    public virtual CcStaffevalRmdCa? CcStaffevalRmdCa { get; set; }

    public virtual CcStaffevalRmdCaFirstPlan? CcStaffevalRmdCaFirstPlan { get; set; }

    public virtual CcStaffevalRmdFixedCa? CcStaffevalRmdFixedCa { get; set; }

    public virtual CcStaffevalRmdSp? CcStaffevalRmdSp { get; set; }

    public virtual CcStaffevalRmdSpFirstPlan? CcStaffevalRmdSpFirstPlan { get; set; }

    public virtual CcStaffevalRmdSpFixed? CcStaffevalRmdSpFixed { get; set; }

    public virtual CcStaffevalRoom? CcStaffevalRoom { get; set; }

    public virtual CcStaffevalStatusList? CcStaffevalStatusList { get; set; }

    public virtual CcStaffevalTestPollsP? CcStaffevalTestPollsP { get; set; }

    public virtual CcStaffevalTestPollsR? CcStaffevalTestPollsR { get; set; }

    public virtual CcStaffevalTestPollsU? CcStaffevalTestPollsU { get; set; }

    public virtual CcStaffevalTso? CcStaffevalTso { get; set; }

    public virtual CcStaffevalTypeRoom? CcStaffevalTypeRoom { get; set; }

    public virtual CcStaffevalTypeTso? CcStaffevalTypeTso { get; set; }

    public virtual CcStaffevalUmmCa? CcStaffevalUmmCa { get; set; }

    public virtual CcStaffevalUmmCaFirstPlan? CcStaffevalUmmCaFirstPlan { get; set; }

    public virtual CcStaffevalUmmFixedCa? CcStaffevalUmmFixedCa { get; set; }

    public virtual CcStaffevalUmmSp? CcStaffevalUmmSp { get; set; }

    public virtual CcStaffevalUmmSpFirstPlan? CcStaffevalUmmSpFirstPlan { get; set; }

    public virtual CcStaffevalUmmSpFixed? CcStaffevalUmmSpFixed { get; set; }

    public virtual CcStaffevalUtpDepartment? CcStaffevalUtpDepartment { get; set; }

    public virtual CcStaffevalUtpDiv? CcStaffevalUtpDiv { get; set; }

    public virtual CcStaffevalUtpGroup? CcStaffevalUtpGroup { get; set; }

    public virtual CcTemplateTheme? CcTemplateTheme { get; set; }

    public virtual CcTheme? CcTheme { get; set; }

    public virtual CcTrainingSubject? CcTrainingSubject { get; set; }

    public virtual CcVersion? CcVersion { get; set; }

    public virtual CcWebNotification? CcWebNotification { get; set; }

    public virtual Certificate? Certificate { get; set; }

    public virtual CertificateType? CertificateType { get; set; }

    public virtual Change? Change { get; set; }

    public virtual Chat? Chat { get; set; }

    public virtual Chatbot? Chatbot { get; set; }

    public virtual ChatbotChat? ChatbotChat { get; set; }

    public virtual ChatbotStage? ChatbotStage { get; set; }

    public virtual ChatbotType? ChatbotType { get; set; }

    public virtual ClConst? ClConst { get; set; }

    public virtual ClCourse? ClCourse { get; set; }

    public virtual ClLocalization? ClLocalization { get; set; }

    public virtual ClModule? ClModule { get; set; }

    public virtual ClObject? ClObject { get; set; }

    public virtual ClShape? ClShape { get; set; }

    public virtual ClSlide? ClSlide { get; set; }

    public virtual Coding? Coding { get; set; }

    public virtual Collaborator? Collaborator { get; set; }

    public virtual CollaboratorSchedule? CollaboratorSchedule { get; set; }

    public virtual CommitteeMember? CommitteeMember { get; set; }

    public virtual Competence? Competence { get; set; }

    public virtual CompetenceBlock? CompetenceBlock { get; set; }

    public virtual CompetenceProfile? CompetenceProfile { get; set; }

    public virtual CompetenceProfileFamily? CompetenceProfileFamily { get; set; }

    public virtual ComponentPackage? ComponentPackage { get; set; }

    public virtual CompoundProgram? CompoundProgram { get; set; }

    public virtual Connection? Connection { get; set; }

    public virtual Contact? Contact { get; set; }

    public virtual ContactResult? ContactResult { get; set; }

    public virtual ContactType? ContactType { get; set; }

    public virtual Contest? Contest { get; set; }

    public virtual Contract? Contract { get; set; }

    public virtual ContractType? ContractType { get; set; }

    public virtual CostCenter? CostCenter { get; set; }

    public virtual Course? Course { get; set; }

    public virtual CourseModule? CourseModule { get; set; }

    public virtual Covenant? Covenant { get; set; }

    public virtual CustomAdminTemplate? CustomAdminTemplate { get; set; }

    public virtual CustomChatbotTemplate? CustomChatbotTemplate { get; set; }

    public virtual CustomReport? CustomReport { get; set; }

    public virtual CustomWebTemplate? CustomWebTemplate { get; set; }

    public virtual CustomWebTemplateGroup? CustomWebTemplateGroup { get; set; }

    public virtual DevelopmentMethod? DevelopmentMethod { get; set; }

    public virtual DevelopmentPlan? DevelopmentPlan { get; set; }

    public virtual DevelopmentPotential? DevelopmentPotential { get; set; }

    public virtual DeviceReg? DeviceReg { get; set; }

    public virtual DigitalSignature? DigitalSignature { get; set; }

    public virtual Dimension? Dimension { get; set; }

    public virtual Discharge? Discharge { get; set; }

    public virtual DnAcademDebt? DnAcademDebt { get; set; }

    public virtual DnAcademYear? DnAcademYear { get; set; }

    public virtual DnAuditorium? DnAuditorium { get; set; }

    public virtual DnBlockDiscipline? DnBlockDiscipline { get; set; }

    public virtual DnControlEvent? DnControlEvent { get; set; }

    public virtual DnControlForm? DnControlForm { get; set; }

    public virtual DnDiscipline? DnDiscipline { get; set; }

    public virtual DnEduCondition? DnEduCondition { get; set; }

    public virtual DnEducatEvent? DnEducatEvent { get; set; }

    public virtual DnEducatForm? DnEducatForm { get; set; }

    public virtual DnIndEducatPlan? DnIndEducatPlan { get; set; }

    public virtual DnLesson? DnLesson { get; set; }

    public virtual DnProgDiscAppend? DnProgDiscAppend { get; set; }

    public virtual DnProgramDiscipl? DnProgramDiscipl { get; set; }

    public virtual DnRegister? DnRegister { get; set; }

    public virtual DnSchedule? DnSchedule { get; set; }

    public virtual DnSpecial? DnSpecial { get; set; }

    public virtual DnSpecialization? DnSpecialization { get; set; }

    public virtual DnStream? DnStream { get; set; }

    public virtual DnStudCentrtestResult? DnStudCentrtestResult { get; set; }

    public virtual DnStudGroup? DnStudGroup { get; set; }

    public virtual DnStudent? DnStudent { get; set; }

    public virtual DnSubjectPlan? DnSubjectPlan { get; set; }

    public virtual DnTerm? DnTerm { get; set; }

    public virtual DnTrainMethodComplex? DnTrainMethodComplex { get; set; }

    public virtual DnWorkCurriculum? DnWorkCurriculum { get; set; }

    public virtual DocType? DocType { get; set; }

    public virtual Document? Document { get; set; }

    public virtual DocumentCommentEntry? DocumentCommentEntry { get; set; }

    public virtual DownloadPackage? DownloadPackage { get; set; }

    public virtual EducationMethod? EducationMethod { get; set; }

    public virtual EducationOrg? EducationOrg { get; set; }

    public virtual EducationPlan? EducationPlan { get; set; }

    public virtual EducationProgram? EducationProgram { get; set; }

    public virtual EfficiencyEstimation? EfficiencyEstimation { get; set; }

    public virtual EstaffEvent? EstaffEvent { get; set; }

    public virtual EstaffEventType? EstaffEventType { get; set; }

    public virtual Event? Event { get; set; }

    public virtual EventAssessmentPlan? EventAssessmentPlan { get; set; }

    public virtual EventResult? EventResult { get; set; }

    public virtual EventResultType? EventResultType { get; set; }

    public virtual EventType? EventType { get; set; }

    public virtual ExchangeServer? ExchangeServer { get; set; }

    public virtual ExclusionReason? ExclusionReason { get; set; }

    public virtual Exercise? Exercise { get; set; }

    public virtual Expense? Expense { get; set; }

    public virtual ExpenseItem? ExpenseItem { get; set; }

    public virtual Expert? Expert { get; set; }

    public virtual ExpertQuestion? ExpertQuestion { get; set; }

    public virtual ExternalSystem? ExternalSystem { get; set; }

    public virtual FileSource? FileSource { get; set; }

    public virtual Forum? Forum { get; set; }

    public virtual ForumEntry? ForumEntry { get; set; }

    public virtual ForumThemeReadByCollaborator? ForumThemeReadByCollaborator { get; set; }

    public virtual Good? Good { get; set; }

    public virtual GoodInstance? GoodInstance { get; set; }

    public virtual GoodType? GoodType { get; set; }

    public virtual Grade? Grade { get; set; }

    public virtual Group? Group { get; set; }

    public virtual Host? Host { get; set; }

    public virtual Indicator? Indicator { get; set; }

    public virtual Invoice? Invoice { get; set; }

    public virtual Item? Item { get; set; }

    public virtual KeyPosition? KeyPosition { get; set; }

    public virtual KeyPositionThreat? KeyPositionThreat { get; set; }

    public virtual KnowledgeClassifier? KnowledgeClassifier { get; set; }

    public virtual KnowledgePart? KnowledgePart { get; set; }

    public virtual KnowledgePartLevel? KnowledgePartLevel { get; set; }

    public virtual KnowledgePartType? KnowledgePartType { get; set; }

    public virtual KnowledgeProfile? KnowledgeProfile { get; set; }

    public virtual Kpi? Kpi { get; set; }

    public virtual KpiProfile? KpiProfile { get; set; }

    public virtual KpiValue? KpiValue { get; set; }

    public virtual Learning? Learning { get; set; }

    public virtual LearningPart? LearningPart { get; set; }

    public virtual LearningRecord? LearningRecord { get; set; }

    public virtual LearningStorage? LearningStorage { get; set; }

    public virtual LearningTask? LearningTask { get; set; }

    public virtual LearningTaskResult? LearningTaskResult { get; set; }

    public virtual Lector? Lector { get; set; }

    public virtual Level? Level { get; set; }

    public virtual LibraryMaterial? LibraryMaterial { get; set; }

    public virtual LibraryMaterialComment? LibraryMaterialComment { get; set; }

    public virtual LibraryMaterialFormat? LibraryMaterialFormat { get; set; }

    public virtual LibraryMaterialItem? LibraryMaterialItem { get; set; }

    public virtual LibraryMaterialLog? LibraryMaterialLog { get; set; }

    public virtual LibraryMaterialSourceType? LibraryMaterialSourceType { get; set; }

    public virtual LibraryMaterialType? LibraryMaterialType { get; set; }

    public virtual LibraryMaterialViewing? LibraryMaterialViewing { get; set; }

    public virtual LibraryPlayer? LibraryPlayer { get; set; }

    public virtual LibrarySection? LibrarySection { get; set; }

    public virtual LibrarySystem? LibrarySystem { get; set; }

    public virtual License? License { get; set; }

    public virtual Like? Like { get; set; }

    public virtual MessengerService? MessengerService { get; set; }

    public virtual MobileAppConfig? MobileAppConfig { get; set; }

    public virtual Notification? Notification { get; set; }

    public virtual NotificationSystem? NotificationSystem { get; set; }

    public virtual NotificationTemplate? NotificationTemplate { get; set; }

    public virtual ObjectData? ObjectData { get; set; }

    public virtual ObjectDataType? ObjectDataType { get; set; }

    public virtual ObjectResource? ObjectResource { get; set; }

    public virtual ObjectVersion? ObjectVersion { get; set; }

    public virtual Objectflow? Objectflow { get; set; }

    public virtual ObjectiveTranslate? ObjectiveTranslate { get; set; }

    public virtual Operation? Operation { get; set; }

    public virtual Order? Order { get; set; }

    public virtual OrderType? OrderType { get; set; }

    public virtual Org? Org { get; set; }

    public virtual OrgVendorState? OrgVendorState { get; set; }

    public virtual OutstaffAdditionalWork? OutstaffAdditionalWork { get; set; }

    public virtual OutstaffContract? OutstaffContract { get; set; }

    public virtual OutstaffOrder? OutstaffOrder { get; set; }

    public virtual OutstaffOrderExecution? OutstaffOrderExecution { get; set; }

    public virtual OutstaffProvider? OutstaffProvider { get; set; }

    public virtual OutstaffTypeMaterial? OutstaffTypeMaterial { get; set; }

    public virtual OverrideWebTemplate? OverrideWebTemplate { get; set; }

    public virtual Pa? Pa { get; set; }

    public virtual Participant? Participant { get; set; }

    public virtual PayPhase? PayPhase { get; set; }

    public virtual PayStage? PayStage { get; set; }

    public virtual Payment? Payment { get; set; }

    public virtual PaymentType? PaymentType { get; set; }

    public virtual PersonObjectLink? PersonObjectLink { get; set; }

    public virtual PersonObjectProfile? PersonObjectProfile { get; set; }

    public virtual PersonnelCommittee? PersonnelCommittee { get; set; }

    public virtual PersonnelReserve? PersonnelReserve { get; set; }

    public virtual Place? Place { get; set; }

    public virtual Plugin? Plugin { get; set; }

    public virtual Poll? Poll { get; set; }

    public virtual PollProcedure? PollProcedure { get; set; }

    public virtual PollResult? PollResult { get; set; }

    public virtual Position? Position { get; set; }

    public virtual PositionAssessmentForm? PositionAssessmentForm { get; set; }

    public virtual PositionCommon? PositionCommon { get; set; }

    public virtual PositionCommonInstruction? PositionCommonInstruction { get; set; }

    public virtual PositionFamily? PositionFamily { get; set; }

    public virtual PositionLevel? PositionLevel { get; set; }

    public virtual PresenceState? PresenceState { get; set; }

    public virtual PrintForm? PrintForm { get; set; }

    public virtual ProctoringSystem? ProctoringSystem { get; set; }

    public virtual ProfessionalArea? ProfessionalArea { get; set; }

    public virtual Profile? Profile { get; set; }

    public virtual ProfilingRecord? ProfilingRecord { get; set; }

    public virtual Project? Project { get; set; }

    public virtual ProjectParticipant? ProjectParticipant { get; set; }

    public virtual Provider? Provider { get; set; }

    public virtual Pryce? Pryce { get; set; }

    public virtual Qualification? Qualification { get; set; }

    public virtual QualificationAssignment? QualificationAssignment { get; set; }

    public virtual Rating? Rating { get; set; }

    public virtual ReadinessLevel? ReadinessLevel { get; set; }

    public virtual Recommendation? Recommendation { get; set; }

    public virtual RecruitmentMethod? RecruitmentMethod { get; set; }

    public virtual RecruitmentPlan? RecruitmentPlan { get; set; }

    public virtual Region? Region { get; set; }

    public virtual RemoteAction? RemoteAction { get; set; }

    public virtual RemoteCollection? RemoteCollection { get; set; }

    public virtual RemoteSecurityProfile? RemoteSecurityProfile { get; set; }

    public virtual Repositorium? Repositorium { get; set; }

    public virtual Reprimand? Reprimand { get; set; }

    public virtual ReprimandType? ReprimandType { get; set; }

    public virtual Request? Request { get; set; }

    public virtual RequestType? RequestType { get; set; }

    public virtual Resource? Resource { get; set; }

    public virtual ResourceType? ResourceType { get; set; }

    public virtual Response? Response { get; set; }

    public virtual ResponseType? ResponseType { get; set; }

    public virtual Resume? Resume { get; set; }

    public virtual RiskLevel? RiskLevel { get; set; }

    public virtual RiskPerspective? RiskPerspective { get; set; }

    public virtual Role? Role { get; set; }

    public virtual SalarySurvey? SalarySurvey { get; set; }

    public virtual SalarySurveySource? SalarySurveySource { get; set; }

    public virtual Sale? Sale { get; set; }

    public virtual SaleContract? SaleContract { get; set; }

    public virtual SaleStatus? SaleStatus { get; set; }

    public virtual ScheduleDay? ScheduleDay { get; set; }

    public virtual ScheduleType? ScheduleType { get; set; }

    public virtual ScriptQueueElem? ScriptQueueElem { get; set; }

    public virtual SectionInstruction? SectionInstruction { get; set; }

    public virtual SelectedResume? SelectedResume { get; set; }

    public virtual SelectedVacancy? SelectedVacancy { get; set; }

    public virtual ServerAgent? ServerAgent { get; set; }

    public virtual Site? Site { get; set; }

    public virtual Skill? Skill { get; set; }

    public virtual Statement? Statement { get; set; }

    public virtual StatisticData? StatisticData { get; set; }

    public virtual StatisticRec? StatisticRec { get; set; }

    public virtual Subdivision? Subdivision { get; set; }

    public virtual SubdivisionGroup? SubdivisionGroup { get; set; }

    public virtual Submission? Submission { get; set; }

    public virtual SubmissionType? SubmissionType { get; set; }

    public virtual Subscription? Subscription { get; set; }

    public virtual Substitution? Substitution { get; set; }

    public virtual SubstitutionType? SubstitutionType { get; set; }

    public virtual Successor? Successor { get; set; }

    public virtual SupplementaryQuestion? SupplementaryQuestion { get; set; }

    public virtual SystemEvent? SystemEvent { get; set; }

    public virtual Tag? Tag { get; set; }

    public virtual TalentPoolNomination? TalentPoolNomination { get; set; }

    public virtual Task? Task { get; set; }

    public virtual TaskType? TaskType { get; set; }

    public virtual Tenancy? Tenancy { get; set; }

    public virtual TestLearning? TestLearning { get; set; }

    public virtual TestProject? TestProject { get; set; }

    public virtual TestingSystem? TestingSystem { get; set; }

    public virtual TrainingPlan? TrainingPlan { get; set; }

    public virtual TraningOrder? TraningOrder { get; set; }

    public virtual Transaction? Transaction { get; set; }

    public virtual Tutor? Tutor { get; set; }

    public virtual TypicalDevelopmentProgram? TypicalDevelopmentProgram { get; set; }

    public virtual UploadPackage? UploadPackage { get; set; }

    public virtual UserAssignment? UserAssignment { get; set; }

    public virtual UserData? UserData { get; set; }

    public virtual Vacancy? Vacancy { get; set; }

    public virtual VacancyResponse? VacancyResponse { get; set; }

    public virtual VacancySource? VacancySource { get; set; }

    public virtual VacancySubscription? VacancySubscription { get; set; }

    public virtual VacancyType? VacancyType { get; set; }

    public virtual VendorState? VendorState { get; set; }

    public virtual Verb? Verb { get; set; }

    public virtual Walkthrough? Walkthrough { get; set; }

    public virtual WebDesign? WebDesign { get; set; }

    public virtual WebRule? WebRule { get; set; }

    public virtual WebinarSystem? WebinarSystem { get; set; }

    public virtual WikiArticle? WikiArticle { get; set; }

    public virtual WikiArticleCommunication? WikiArticleCommunication { get; set; }

    public virtual WikiArticleCommunicationType? WikiArticleCommunicationType { get; set; }

    public virtual WikiArticleType? WikiArticleType { get; set; }

    public virtual WikiBase? WikiBase { get; set; }

    public virtual WorkSchedule? WorkSchedule { get; set; }

    public virtual Workflow? Workflow { get; set; }
}

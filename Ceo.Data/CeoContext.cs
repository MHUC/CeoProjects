namespace Ceo.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CeoContext : DbContext
    {
        public CeoContext()
            : base("name=CeoContext")
        {
        }

        public virtual DbSet<dtproperty> dtproperties { get; set; }
        public virtual DbSet<history_store> history_store { get; set; }
        public virtual DbSet<lkpAdjustmentType> lkpAdjustmentTypes { get; set; }
        public virtual DbSet<lkpAuditedProperty> lkpAuditedProperties { get; set; }
        public virtual DbSet<lkpBank> lkpBanks { get; set; }
        public virtual DbSet<lkpBillPayer> lkpBillPayers { get; set; }
        public virtual DbSet<lkpBuildDep> lkpBuildDeps { get; set; }
        public virtual DbSet<lkpCampaignCategory> lkpCampaignCategories { get; set; }
        public virtual DbSet<lkpCategory> lkpCategories { get; set; }
        public virtual DbSet<lkpCCType> lkpCCTypes { get; set; }
        public virtual DbSet<lkpChargeType> lkpChargeTypes { get; set; }
        public virtual DbSet<lkpCustomDropDown> lkpCustomDropDowns { get; set; }
        public virtual DbSet<lkpCustomerStatu> lkpCustomerStatus { get; set; }
        public virtual DbSet<lkpCustomerSubType> lkpCustomerSubTypes { get; set; }
        public virtual DbSet<lkpCustomerType> lkpCustomerTypes { get; set; }
        public virtual DbSet<lkpCustomFieldMaster> lkpCustomFieldMasters { get; set; }
        public virtual DbSet<lkpEmployeeStatu> lkpEmployeeStatus { get; set; }
        public virtual DbSet<lkpEmployeeSubType> lkpEmployeeSubTypes { get; set; }
        public virtual DbSet<lkpEmpPayType> lkpEmpPayTypes { get; set; }
        public virtual DbSet<lkpInventoryReturnCode> lkpInventoryReturnCodes { get; set; }
        public virtual DbSet<lkpInvoiceStatu> lkpInvoiceStatus { get; set; }
        public virtual DbSet<lkpInvoiceType> lkpInvoiceTypes { get; set; }
        public virtual DbSet<lkpInvStatu> lkpInvStatus { get; set; }
        public virtual DbSet<lkpInvSubStatu> lkpInvSubStatus { get; set; }
        public virtual DbSet<lkpJobStatu> lkpJobStatus { get; set; }
        public virtual DbSet<lkpJobSubStatu> lkpJobSubStatus { get; set; }
        public virtual DbSet<lkpKit> lkpKits { get; set; }
        public virtual DbSet<lkpMarketingCode> lkpMarketingCodes { get; set; }
        public virtual DbSet<lkpMethodOfPayment> lkpMethodOfPayments { get; set; }
        public virtual DbSet<lkpNoteCode> lkpNoteCodes { get; set; }
        public virtual DbSet<lkpOSEquipStatu> lkpOSEquipStatus { get; set; }
        public virtual DbSet<lkpOSEquipSubStatu> lkpOSEquipSubStatus { get; set; }
        public virtual DbSet<lkpOTRule> lkpOTRules { get; set; }
        public virtual DbSet<lkpPayAdjType> lkpPayAdjTypes { get; set; }
        public virtual DbSet<lkpPaycheckDetailType> lkpPaycheckDetailTypes { get; set; }
        public virtual DbSet<lkpPayCycle> lkpPayCycles { get; set; }
        public virtual DbSet<lkpPayMarital> lkpPayMaritals { get; set; }
        public virtual DbSet<lkpPOHistoryCode> lkpPOHistoryCodes { get; set; }
        public virtual DbSet<lkpPriceLevel> lkpPriceLevels { get; set; }
        public virtual DbSet<lkpProduct> lkpProducts { get; set; }
        public virtual DbSet<lkpQBExpType> lkpQBExpTypes { get; set; }
        public virtual DbSet<lkpQBPackage> lkpQBPackages { get; set; }
        public virtual DbSet<lkpQuoteGroup> lkpQuoteGroups { get; set; }
        public virtual DbSet<lkpQuoteItem> lkpQuoteItems { get; set; }
        public virtual DbSet<lkpQuoteItemType> lkpQuoteItemTypes { get; set; }
        public virtual DbSet<lkpQuoteJobType> lkpQuoteJobTypes { get; set; }
        public virtual DbSet<lkpQuotePickList> lkpQuotePickLists { get; set; }
        public virtual DbSet<lkpQuoteQtyType> lkpQuoteQtyTypes { get; set; }
        public virtual DbSet<lkpSchedEventType> lkpSchedEventTypes { get; set; }
        public virtual DbSet<lkpServConStatu> lkpServConStatus { get; set; }
        public virtual DbSet<lkpServConSubStatu> lkpServConSubStatus { get; set; }
        public virtual DbSet<lkpService> lkpServices { get; set; }
        public virtual DbSet<lkpSkill> lkpSkills { get; set; }
        public virtual DbSet<lkpSupplier> lkpSuppliers { get; set; }
        public virtual DbSet<lkpTaskParentChrgType> lkpTaskParentChrgTypes { get; set; }
        public virtual DbSet<lkpTaskParentType> lkpTaskParentTypes { get; set; }
        public virtual DbSet<lkpTaxCode> lkpTaxCodes { get; set; }
        public virtual DbSet<lkpTaxType> lkpTaxTypes { get; set; }
        public virtual DbSet<lkpTemplate> lkpTemplates { get; set; }
        public virtual DbSet<lkpTendProp> lkpTendProps { get; set; }
        public virtual DbSet<lkpTimeCode> lkpTimeCodes { get; set; }
        public virtual DbSet<lkpTransactionType> lkpTransactionTypes { get; set; }
        public virtual DbSet<lkpUnit> lkpUnits { get; set; }
        public virtual DbSet<lkpUserGroupRight> lkpUserGroupRights { get; set; }
        public virtual DbSet<lkpWebEvent> lkpWebEvents { get; set; }
        public virtual DbSet<lkpZIPCode> lkpZIPCodes { get; set; }
        public virtual DbSet<lkpZIPZoneLink> lkpZIPZoneLinks { get; set; }
        public virtual DbSet<lkpZonePricing> lkpZonePricings { get; set; }
        public virtual DbSet<lkpZone> lkpZones { get; set; }
        public virtual DbSet<lnkBranchInventory> lnkBranchInventories { get; set; }
        public virtual DbSet<lnkBranchProfile> lnkBranchProfiles { get; set; }
        public virtual DbSet<lnkCategoryAccount> lnkCategoryAccounts { get; set; }
        public virtual DbSet<lnkDispatch> lnkDispatches { get; set; }
        public virtual DbSet<lnkDoc> lnkDocs { get; set; }
        public virtual DbSet<lnkHolidayAssign> lnkHolidayAssigns { get; set; }
        public virtual DbSet<lnkInventory> lnkInventories { get; set; }
        public virtual DbSet<lnkKitItem> lnkKitItems { get; set; }
        public virtual DbSet<lnkLocInvLevel> lnkLocInvLevels { get; set; }
        public virtual DbSet<lnkNSInventory> lnkNSInventories { get; set; }
        public virtual DbSet<lnkOrgCustPayType> lnkOrgCustPayTypes { get; set; }
        public virtual DbSet<lnkOTRuleAccount> lnkOTRuleAccounts { get; set; }
        public virtual DbSet<lnkOTRuleAppl> lnkOTRuleAppls { get; set; }
        public virtual DbSet<lnkOTRuleOR> lnkOTRuleORs { get; set; }
        public virtual DbSet<lnkPayAdjAccount> lnkPayAdjAccounts { get; set; }
        public virtual DbSet<lnkProdServTask> lnkProdServTasks { get; set; }
        public virtual DbSet<lnkQBSupplier> lnkQBSuppliers { get; set; }
        public virtual DbSet<lnkQuoteGroupItem> lnkQuoteGroupItems { get; set; }
        public virtual DbSet<lnkQuoteGroupP> lnkQuoteGroupPS { get; set; }
        public virtual DbSet<lnkQuoteJobTypeGroup> lnkQuoteJobTypeGroups { get; set; }
        public virtual DbSet<lnkQuoteJobTypeItemOrder> lnkQuoteJobTypeItemOrders { get; set; }
        public virtual DbSet<lnkQuotePickListQty> lnkQuotePickListQties { get; set; }
        public virtual DbSet<lnkRegionInventory> lnkRegionInventories { get; set; }
        public virtual DbSet<lnkRegionProfile> lnkRegionProfiles { get; set; }
        public virtual DbSet<lnkServConLineEquip> lnkServConLineEquips { get; set; }
        public virtual DbSet<lnkServConLineP> lnkServConLinePS { get; set; }
        public virtual DbSet<lnkTaskAssign> lnkTaskAssigns { get; set; }
        public virtual DbSet<lnkTendProp> lnkTendProps { get; set; }
        public virtual DbSet<lnkZonePricingP> lnkZonePricingPS { get; set; }
        public virtual DbSet<sysGraph> sysGraphs { get; set; }
        public virtual DbSet<sysGridSetting> sysGridSettings { get; set; }
        public virtual DbSet<sysListField> sysListFields { get; set; }
        public virtual DbSet<sysListGroup> sysListGroups { get; set; }
        public virtual DbSet<sysListUserPref> sysListUserPrefs { get; set; }
        public virtual DbSet<sysMemoOption> sysMemoOptions { get; set; }
        public virtual DbSet<sysOption> sysOptions { get; set; }
        public virtual DbSet<sysProgress> sysProgresses { get; set; }
        public virtual DbSet<sysReport> sysReports { get; set; }
        public virtual DbSet<sysValidatorLog> sysValidatorLogs { get; set; }
        public virtual DbSet<tblAdjustment> tblAdjustments { get; set; }
        public virtual DbSet<tblAudit> tblAudits { get; set; }
        public virtual DbSet<tblBatchCommSumm> tblBatchCommSumms { get; set; }
        public virtual DbSet<tblBatchJobProduct> tblBatchJobProducts { get; set; }
        public virtual DbSet<tblBatchJob> tblBatchJobs { get; set; }
        public virtual DbSet<tblBatchJobService> tblBatchJobServices { get; set; }
        public virtual DbSet<tblBonusRule> tblBonusRules { get; set; }
        public virtual DbSet<tblBranch> tblBranches { get; set; }
        public virtual DbSet<tblCallCmdProp> tblCallCmdProps { get; set; }
        public virtual DbSet<tblCallCmd> tblCallCmds { get; set; }
        public virtual DbSet<tblCallField> tblCallFields { get; set; }
        public virtual DbSet<tblCallFieldSet> tblCallFieldSets { get; set; }
        public virtual DbSet<tblCallType> tblCallTypes { get; set; }
        public virtual DbSet<tblCancellation> tblCancellations { get; set; }
        public virtual DbSet<tblCapAdjust> tblCapAdjusts { get; set; }
        public virtual DbSet<tblCapSlot> tblCapSlots { get; set; }
        public virtual DbSet<tblCapWindow> tblCapWindows { get; set; }
        public virtual DbSet<tblChrgAppl> tblChrgAppls { get; set; }
        public virtual DbSet<tblCommProduct> tblCommProducts { get; set; }
        public virtual DbSet<tblCommService> tblCommServices { get; set; }
        public virtual DbSet<tblCompleteJobType> tblCompleteJobTypes { get; set; }
        public virtual DbSet<tblCompleteMisc> tblCompleteMiscs { get; set; }
        public virtual DbSet<tblCompleteProduct> tblCompleteProducts { get; set; }
        public virtual DbSet<tblCompleteQuoteGroup> tblCompleteQuoteGroups { get; set; }
        public virtual DbSet<tblCompleteQuoteItem> tblCompleteQuoteItems { get; set; }
        public virtual DbSet<tblCompleteService> tblCompleteServices { get; set; }
        public virtual DbSet<tblCompProfile> tblCompProfiles { get; set; }
        public virtual DbSet<tblCompTimeBlock> tblCompTimeBlocks { get; set; }
        public virtual DbSet<tblContact> tblContacts { get; set; }
        public virtual DbSet<tblCustomerCommunicationHistory> tblCustomerCommunicationHistories { get; set; }
        public virtual DbSet<tblCustomerNote> tblCustomerNotes { get; set; }
        public virtual DbSet<tblCustomer> tblCustomers { get; set; }
        public virtual DbSet<tblDemographic> tblDemographics { get; set; }
        public virtual DbSet<tblDemographicData> tblDemographicDatas { get; set; }
        public virtual DbSet<tblDeposit> tblDeposits { get; set; }
        public virtual DbSet<tblDispatchEmpWorkHour> tblDispatchEmpWorkHours { get; set; }
        public virtual DbSet<tblDispatchJobNote> tblDispatchJobNotes { get; set; }
        public virtual DbSet<tblDroppedInvoice> tblDroppedInvoices { get; set; }
        public virtual DbSet<tblEmpLossTeamLink> tblEmpLossTeamLinks { get; set; }
        public virtual DbSet<tblEmpLossTeam> tblEmpLossTeams { get; set; }
        public virtual DbSet<tblEmployeeNote> tblEmployeeNotes { get; set; }
        public virtual DbSet<tblEmployee> tblEmployees { get; set; }
        public virtual DbSet<tblEmployeeSharing> tblEmployeeSharings { get; set; }
        public virtual DbSet<tblEmployeeSignout> tblEmployeeSignouts { get; set; }
        public virtual DbSet<tblEmpWorkHour> tblEmpWorkHours { get; set; }
        public virtual DbSet<tblEstNote> tblEstNotes { get; set; }
        public virtual DbSet<tblFranchise> tblFranchises { get; set; }
        public virtual DbSet<tblHoliday> tblHolidays { get; set; }
        public virtual DbSet<tblInquiry> tblInquiries { get; set; }
        public virtual DbSet<tblInvAdjAcct> tblInvAdjAccts { get; set; }
        public virtual DbSet<tblInvAvgCost> tblInvAvgCosts { get; set; }
        public virtual DbSet<tblInvoiceProduct> tblInvoiceProducts { get; set; }
        public virtual DbSet<tblInvoice> tblInvoices { get; set; }
        public virtual DbSet<tblInvoiceService> tblInvoiceServices { get; set; }
        public virtual DbSet<tblInvTransfer> tblInvTransfers { get; set; }
        public virtual DbSet<tblInvTransTicket> tblInvTransTickets { get; set; }
        public virtual DbSet<tblJob> tblJobs { get; set; }
        public virtual DbSet<tblKitInstance> tblKitInstances { get; set; }
        public virtual DbSet<tblLimbo> tblLimboes { get; set; }
        public virtual DbSet<tblLocation> tblLocations { get; set; }
        public virtual DbSet<tblLocking> tblLockings { get; set; }
        public virtual DbSet<tblMiscCharge> tblMiscCharges { get; set; }
        public virtual DbSet<tblOrganisation> tblOrganisations { get; set; }
        public virtual DbSet<tblOSEquip> tblOSEquips { get; set; }
        public virtual DbSet<tblPaycheckDetail> tblPaycheckDetails { get; set; }
        public virtual DbSet<tblPayCheck> tblPayChecks { get; set; }
        public virtual DbSet<tblPayrollAdj> tblPayrollAdjs { get; set; }
        public virtual DbSet<tblPO> tblPOes { get; set; }
        public virtual DbSet<tblPOHistory> tblPOHistories { get; set; }
        public virtual DbSet<tblPOItemIntent> tblPOItemIntents { get; set; }
        public virtual DbSet<tblPOItem> tblPOItems { get; set; }
        public virtual DbSet<tblQBExport> tblQBExports { get; set; }
        public virtual DbSet<tblQuote> tblQuotes { get; set; }
        public virtual DbSet<tblRefund> tblRefunds { get; set; }
        public virtual DbSet<tblRefundItem> tblRefundItems { get; set; }
        public virtual DbSet<tblRegion> tblRegions { get; set; }
        public virtual DbSet<tblReturn> tblReturns { get; set; }
        public virtual DbSet<tblSchedProd> tblSchedProds { get; set; }
        public virtual DbSet<tblSchedService> tblSchedServices { get; set; }
        public virtual DbSet<tblSchedule> tblSchedules { get; set; }
        public virtual DbSet<tblServConLine> tblServConLines { get; set; }
        public virtual DbSet<tblServContract> tblServContracts { get; set; }
        public virtual DbSet<tblSkillInstance> tblSkillInstances { get; set; }
        public virtual DbSet<tblStockLocation> tblStockLocations { get; set; }
        public virtual DbSet<tblSubStockLocation> tblSubStockLocations { get; set; }
        public virtual DbSet<tblSupplierCatalog> tblSupplierCatalogs { get; set; }
        public virtual DbSet<tblTaskNote> tblTaskNotes { get; set; }
        public virtual DbSet<tblTask> tblTasks { get; set; }
        public virtual DbSet<tblTaskSched> tblTaskScheds { get; set; }
        public virtual DbSet<tblTeamDayProp> tblTeamDayProps { get; set; }
        public virtual DbSet<tblTeamEmployee> tblTeamEmployees { get; set; }
        public virtual DbSet<tblTeam> tblTeams { get; set; }
        public virtual DbSet<tblTender> tblTenders { get; set; }
        public virtual DbSet<tblTimeCard> tblTimeCards { get; set; }
        public virtual DbSet<tblTransaction> tblTransactions { get; set; }
        public virtual DbSet<tblUnavailEmp> tblUnavailEmps { get; set; }
        public virtual DbSet<tblUserGroupLink> tblUserGroupLinks { get; set; }
        public virtual DbSet<tblUserGroupRightLink> tblUserGroupRightLinks { get; set; }
        public virtual DbSet<tblUserGroup> tblUserGroups { get; set; }
        public virtual DbSet<tblUserSecurity> tblUserSecurities { get; set; }
        public virtual DbSet<tblVersion> tblVersions { get; set; }
        public virtual DbSet<tblWebEvent> tblWebEvents { get; set; }
        public virtual DbSet<tblWebJobNote> tblWebJobNotes { get; set; }
        public virtual DbSet<C__history__> C__history__ { get; set; }
        public virtual DbSet<lkpChrgStatu> lkpChrgStatus { get; set; }
        public virtual DbSet<lkpDebitType> lkpDebitTypes { get; set; }
        public virtual DbSet<lkpDocParentType> lkpDocParentTypes { get; set; }
        public virtual DbSet<lkpEntityNumber> lkpEntityNumbers { get; set; }
        public virtual DbSet<lkpPaymentTerm> lkpPaymentTerms { get; set; }
        public virtual DbSet<lkpRstrSS> lkpRstrSSes { get; set; }
        public virtual DbSet<lnkBonusPropertyList> lnkBonusPropertyLists { get; set; }
        public virtual DbSet<lnkBonusRuleAccount> lnkBonusRuleAccounts { get; set; }
        public virtual DbSet<lnkEmpUserGroup> lnkEmpUserGroups { get; set; }
        public virtual DbSet<lnkQBInvoiceExport> lnkQBInvoiceExports { get; set; }
        public virtual DbSet<lnkTeamAppointment> lnkTeamAppointments { get; set; }
        public virtual DbSet<lnkTeamCategory> lnkTeamCategories { get; set; }
        public virtual DbSet<lnkTeamCustomer> lnkTeamCustomers { get; set; }
        public virtual DbSet<lnkTeamSubStatu> lnkTeamSubStatus { get; set; }
        public virtual DbSet<MD_AssignedInventory> MD_AssignedInventory { get; set; }
        public virtual DbSet<MD_NewInventory> MD_NewInventory { get; set; }
        public virtual DbSet<MD_tblJobs> MD_tblJobs { get; set; }
        public virtual DbSet<MD_tblPayment> MD_tblPayment { get; set; }
        public virtual DbSet<MD_tblPaymentDetails> MD_tblPaymentDetails { get; set; }
        public virtual DbSet<MD_tblPayroll> MD_tblPayroll { get; set; }
        public virtual DbSet<MD_tblProductCharges> MD_tblProductCharges { get; set; }
        public virtual DbSet<MD_tblServiceCharges> MD_tblServiceCharges { get; set; }
        public virtual DbSet<MD_tblTimestamps> MD_tblTimestamps { get; set; }
        public virtual DbSet<tblBillingProp> tblBillingProps { get; set; }
        public virtual DbSet<tblBillingSplit> tblBillingSplits { get; set; }
        public virtual DbSet<tblBonu> tblBonus { get; set; }
        public virtual DbSet<tblChrgApplGrp> tblChrgApplGrps { get; set; }
        public virtual DbSet<tblEstimate> tblEstimates { get; set; }
        public virtual DbSet<tblNamedView> tblNamedViews { get; set; }
        public virtual DbSet<tblNamedViewProp> tblNamedViewProps { get; set; }
        public virtual DbSet<tblOrder> tblOrders { get; set; }
        public virtual DbSet<tblPOMiscItem> tblPOMiscItems { get; set; }
        public virtual DbSet<tblTeamZone> tblTeamZones { get; set; }
        public virtual DbSet<tblTemplate> tblTemplates { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<dtproperty>()
                .Property(e => e.property)
                .IsUnicode(false);

            modelBuilder.Entity<dtproperty>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<lkpAdjustmentType>()
                .HasMany(e => e.tblAdjustments)
                .WithRequired(e => e.lkpAdjustmentType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpBillPayer>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<lkpBuildDep>()
                .HasMany(e => e.lnkNSInventories)
                .WithRequired(e => e.lkpBuildDep)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpCategory>()
                .HasMany(e => e.lkpKits)
                .WithRequired(e => e.lkpCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpCategory>()
                .HasMany(e => e.lnkCategoryAccounts)
                .WithRequired(e => e.lkpCategory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpChargeType>()
                .HasMany(e => e.tblServConLines)
                .WithRequired(e => e.lkpChargeType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpEmployeeSubType>()
                .HasMany(e => e.tblCompTimeBlocks)
                .WithRequired(e => e.lkpEmployeeSubType)
                .HasForeignKey(e => e.SubTypeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpInvStatu>()
                .HasMany(e => e.lkpInvSubStatus)
                .WithRequired(e => e.lkpInvStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpInvStatu>()
                .HasMany(e => e.lnkInventories)
                .WithRequired(e => e.lkpInvStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpInvStatu>()
                .HasMany(e => e.lnkNSInventories)
                .WithRequired(e => e.lkpInvStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpInvSubStatu>()
                .HasMany(e => e.lnkInventories)
                .WithRequired(e => e.lkpInvSubStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpInvSubStatu>()
                .HasMany(e => e.lnkNSInventories)
                .WithRequired(e => e.lkpInvSubStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpJobStatu>()
                .HasMany(e => e.lkpJobSubStatus)
                .WithRequired(e => e.lkpJobStatu)
                .HasForeignKey(e => e.StatusID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpJobStatu>()
                .HasMany(e => e.lkpRstrSSes)
                .WithRequired(e => e.lkpJobStatu)
                .HasForeignKey(e => e.StatusID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpJobStatu>()
                .HasMany(e => e.lkpRstrSSes1)
                .WithRequired(e => e.lkpJobStatu1)
                .HasForeignKey(e => e.RstrStatusID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpJobStatu>()
                .HasMany(e => e.tblBatchJobs)
                .WithRequired(e => e.lkpJobStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpJobStatu>()
                .HasMany(e => e.tblTasks)
                .WithRequired(e => e.lkpJobStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpJobStatu>()
                .HasMany(e => e.tblTaskScheds)
                .WithRequired(e => e.lkpJobStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpJobSubStatu>()
                .HasMany(e => e.lkpJobStatus)
                .WithOptional(e => e.lkpJobSubStatu)
                .HasForeignKey(e => e.DefaultSubStatusID);

            modelBuilder.Entity<lkpJobSubStatu>()
                .HasMany(e => e.lkpRstrSSes)
                .WithOptional(e => e.lkpJobSubStatu)
                .HasForeignKey(e => e.SubStatusID);

            modelBuilder.Entity<lkpJobSubStatu>()
                .HasMany(e => e.lkpRstrSSes1)
                .WithOptional(e => e.lkpJobSubStatu1)
                .HasForeignKey(e => e.RstrSubStatusID);

            modelBuilder.Entity<lkpJobSubStatu>()
                .HasMany(e => e.tblJobs)
                .WithRequired(e => e.lkpJobSubStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpJobSubStatu>()
                .HasMany(e => e.tblSchedules)
                .WithRequired(e => e.lkpJobSubStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpJobSubStatu>()
                .HasMany(e => e.tblTasks)
                .WithRequired(e => e.lkpJobSubStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpJobSubStatu>()
                .HasMany(e => e.tblTaskScheds)
                .WithRequired(e => e.lkpJobSubStatu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpKit>()
                .HasMany(e => e.lnkKitItems)
                .WithRequired(e => e.lkpKit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpKit>()
                .HasMany(e => e.tblKitInstances)
                .WithRequired(e => e.lkpKit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpMarketingCode>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lkpMarketingCode>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<lkpMarketingCode>()
                .Property(e => e.BudgetAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lkpMethodOfPayment>()
                .HasMany(e => e.lkpBillPayers)
                .WithRequired(e => e.lkpMethodOfPayment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpMethodOfPayment>()
                .HasMany(e => e.tblRefunds)
                .WithRequired(e => e.lkpMethodOfPayment)
                .HasForeignKey(e => e.RefundMethodID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpMethodOfPayment>()
                .HasMany(e => e.lnkOrgCustPayTypes)
                .WithRequired(e => e.lkpMethodOfPayment)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpNoteCode>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<lkpNoteCode>()
                .HasMany(e => e.tblEstNotes)
                .WithRequired(e => e.lkpNoteCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpNoteCode>()
                .HasMany(e => e.tblQuotes)
                .WithRequired(e => e.lkpNoteCode)
                .HasForeignKey(e => e.CancelNoteCodeID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpNoteCode>()
                .HasMany(e => e.tblWebJobNotes)
                .WithRequired(e => e.lkpNoteCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpOTRule>()
                .Property(e => e.Multiplier)
                .HasPrecision(9, 4);

            modelBuilder.Entity<lkpOTRule>()
                .Property(e => e.HrsLimit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lkpOTRule>()
                .HasMany(e => e.lnkOTRuleAccounts)
                .WithRequired(e => e.lkpOTRule)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpOTRule>()
                .HasMany(e => e.lnkOTRuleAppls)
                .WithRequired(e => e.lkpOTRule)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpOTRule>()
                .HasMany(e => e.lnkOTRuleORs)
                .WithRequired(e => e.lkpOTRule)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpPayAdjType>()
                .HasMany(e => e.lnkPayAdjAccounts)
                .WithRequired(e => e.lkpPayAdjType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpPayAdjType>()
                .HasMany(e => e.tblPayrollAdjs)
                .WithRequired(e => e.lkpPayAdjType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpPaycheckDetailType>()
                .HasMany(e => e.tblPaycheckDetails)
                .WithRequired(e => e.lkpPaycheckDetailType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpPayCycle>()
                .HasMany(e => e.lkpEmployeeSubTypes)
                .WithRequired(e => e.lkpPayCycle)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpPayMarital>()
                .HasMany(e => e.tblEmployees)
                .WithRequired(e => e.lkpPayMarital)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpPOHistoryCode>()
                .HasMany(e => e.tblPOHistories)
                .WithRequired(e => e.lkpPOHistoryCode)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpPriceLevel>()
                .Property(e => e.ServicePercentMultiplier)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lkpPriceLevel>()
                .Property(e => e.ProductPercentMultiplier)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lkpPriceLevel>()
                .Property(e => e.RecTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<lkpProduct>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<lkpProduct>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lkpProduct>()
                .Property(e => e.SellPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lkpProduct>()
                .HasMany(e => e.tblCommProducts)
                .WithRequired(e => e.lkpProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpProduct>()
                .HasMany(e => e.lnkInventories)
                .WithRequired(e => e.lkpProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpProduct>()
                .HasMany(e => e.lnkLocInvLevels)
                .WithRequired(e => e.lkpProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpProduct>()
                .HasMany(e => e.lnkQuoteGroupPS)
                .WithRequired(e => e.lkpProduct)
                .HasForeignKey(e => e.InventoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpProduct>()
                .HasMany(e => e.lnkZonePricingPS)
                .WithRequired(e => e.lkpProduct)
                .HasForeignKey(e => e.InventoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpProduct>()
                .HasMany(e => e.tblInvAdjAccts)
                .WithRequired(e => e.lkpProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpProduct>()
                .HasMany(e => e.tblReturns)
                .WithRequired(e => e.lkpProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpProduct>()
                .HasMany(e => e.tblSupplierCatalogs)
                .WithRequired(e => e.lkpProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpQBPackage>()
                .HasMany(e => e.tblBranches)
                .WithRequired(e => e.lkpQBPackage)
                .HasForeignKey(e => e.QBPackage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpQBPackage>()
                .HasMany(e => e.tblBranches1)
                .WithOptional(e => e.lkpQBPackage1)
                .HasForeignKey(e => e.PayrollPackage);

            modelBuilder.Entity<lkpQBPackage>()
                .HasMany(e => e.tblCompProfiles)
                .WithRequired(e => e.lkpQBPackage)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpQuoteGroup>()
                .HasMany(e => e.lnkQuoteGroupItems)
                .WithRequired(e => e.lkpQuoteGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpQuoteGroup>()
                .HasMany(e => e.lnkQuoteGroupPS)
                .WithRequired(e => e.lkpQuoteGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpQuoteGroup>()
                .HasMany(e => e.lnkQuoteJobTypeGroups)
                .WithRequired(e => e.lkpQuoteGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpQuoteGroup>()
                .HasMany(e => e.lnkQuotePickListQties)
                .WithRequired(e => e.lkpQuoteGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpQuoteGroup>()
                .HasMany(e => e.tblCompleteQuoteGroups)
                .WithRequired(e => e.lkpQuoteGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpQuoteItem>()
                .HasMany(e => e.lkpQuotePickLists)
                .WithRequired(e => e.lkpQuoteItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpQuoteItem>()
                .HasMany(e => e.lnkQuoteGroupItems)
                .WithRequired(e => e.lkpQuoteItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpQuoteItem>()
                .HasMany(e => e.lnkQuoteJobTypeItemOrders)
                .WithRequired(e => e.lkpQuoteItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpQuoteItem>()
                .HasMany(e => e.tblCompleteQuoteItems)
                .WithRequired(e => e.lkpQuoteItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpQuoteItemType>()
                .HasMany(e => e.lkpQuoteItems)
                .WithRequired(e => e.lkpQuoteItemType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpQuoteJobType>()
                .HasMany(e => e.lnkQuoteJobTypeGroups)
                .WithRequired(e => e.lkpQuoteJobType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpQuoteJobType>()
                .HasMany(e => e.lnkQuoteJobTypeItemOrders)
                .WithRequired(e => e.lkpQuoteJobType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpQuoteJobType>()
                .HasMany(e => e.tblCompleteJobTypes)
                .WithRequired(e => e.lkpQuoteJobType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpQuotePickList>()
                .Property(e => e.Order)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<lkpQuotePickList>()
                .HasMany(e => e.lnkQuotePickListQties)
                .WithRequired(e => e.lkpQuotePickList)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpQuotePickList>()
                .HasMany(e => e.tblCompleteQuoteItems)
                .WithRequired(e => e.lkpQuotePickList)
                .HasForeignKey(e => e.DataLink)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpQuoteQtyType>()
                .HasMany(e => e.lkpQuoteGroups)
                .WithRequired(e => e.lkpQuoteQtyType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpService>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lkpService>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<lkpService>()
                .Property(e => e.MinDuration)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lkpService>()
                .HasMany(e => e.tblCommServices)
                .WithRequired(e => e.lkpService)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpService>()
                .HasMany(e => e.lnkQuoteGroupPS)
                .WithRequired(e => e.lkpService)
                .HasForeignKey(e => e.InventoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpService>()
                .HasMany(e => e.lnkZonePricingPS)
                .WithRequired(e => e.lkpService)
                .HasForeignKey(e => e.InventoryID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpSupplier>()
                .HasMany(e => e.lnkQBSuppliers)
                .WithRequired(e => e.lkpSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpSupplier>()
                .HasMany(e => e.tblPOes)
                .WithRequired(e => e.lkpSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpSupplier>()
                .HasMany(e => e.tblSupplierCatalogs)
                .WithRequired(e => e.lkpSupplier)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpTaxCode>()
                .HasMany(e => e.tblLocations)
                .WithRequired(e => e.lkpTaxCode)
                .HasForeignKey(e => e.TaxCodeID1)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpTaxCode>()
                .HasMany(e => e.tblLocations1)
                .WithRequired(e => e.lkpTaxCode1)
                .HasForeignKey(e => e.TaxCodeID2)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpTaxCode>()
                .HasMany(e => e.tblLocations2)
                .WithRequired(e => e.lkpTaxCode2)
                .HasForeignKey(e => e.TaxCodeID3)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpTaxType>()
                .HasMany(e => e.lkpTaxCodes)
                .WithRequired(e => e.lkpTaxType)
                .HasForeignKey(e => new { e.OrganisationID, e.TaxTypeID })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpTemplate>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<lkpTendProp>()
                .HasMany(e => e.lnkTendProps)
                .WithRequired(e => e.lkpTendProp)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpUnit>()
                .HasMany(e => e.tblServConLines)
                .WithRequired(e => e.lkpUnit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpUserGroupRight>()
                .HasMany(e => e.tblUserGroupRightLinks)
                .WithRequired(e => e.lkpUserGroupRight)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpWebEvent>()
                .HasMany(e => e.tblWebEvents)
                .WithRequired(e => e.lkpWebEvent)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpZIPCode>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<lkpZonePricing>()
                .HasMany(e => e.lnkZonePricingPS)
                .WithRequired(e => e.lkpZonePricing)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpZonePricing>()
                .HasMany(e => e.tblQuotes)
                .WithRequired(e => e.lkpZonePricing)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpZone>()
                .HasMany(e => e.tblTeamZones)
                .WithRequired(e => e.lkpZone)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lkpZone>()
                .HasMany(e => e.tblLocations)
                .WithRequired(e => e.lkpZone)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lnkDispatch>()
                .Property(e => e.BillingRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lnkDispatch>()
                .HasMany(e => e.tblBatchCommSumms)
                .WithRequired(e => e.lnkDispatch)
                .HasForeignKey(e => e.EmpInstID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lnkInventory>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lnkInventory>()
                .Property(e => e.SellPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lnkInventory>()
                .Property(e => e.MiscDistribCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lnkInventory>()
                .HasMany(e => e.tblOSEquips)
                .WithRequired(e => e.lnkInventory)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lnkInventory>()
                .HasMany(e => e.lnkInventory1)
                .WithRequired(e => e.lnkInventory2)
                .HasForeignKey(e => e.OrigInventoryID);

            modelBuilder.Entity<lnkKitItem>()
                .Property(e => e.QtyPerKit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lnkKitItem>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lnkNSInventory>()
                .Property(e => e.SellPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lnkNSInventory>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lnkNSInventory>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lnkNSInventory>()
                .Property(e => e.UnitMiscDistribCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lnkNSInventory>()
                .HasMany(e => e.tblInvAvgCosts)
                .WithOptional(e => e.lnkNSInventory)
                .HasForeignKey(e => e.NSRecordID);

            modelBuilder.Entity<lnkOrgCustPayType>()
                .Property(e => e.OrgDescription)
                .IsUnicode(false);

            modelBuilder.Entity<lnkOTRuleOR>()
                .Property(e => e.Multiplier)
                .HasPrecision(9, 4);

            modelBuilder.Entity<lnkOTRuleOR>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lnkTaskAssign>()
                .Property(e => e.PayRateAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<lnkTaskAssign>()
                .Property(e => e.PayMiscAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<sysGraph>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<sysListGroup>()
                .HasMany(e => e.sysListFields)
                .WithRequired(e => e.sysListGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sysMemoOption>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<sysReport>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<sysReport>()
                .HasMany(e => e.lnkDocs)
                .WithOptional(e => e.sysReport)
                .HasForeignKey(e => e.ReportID);

            modelBuilder.Entity<tblAdjustment>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblAdjustment>()
                .Property(e => e.TaxPct1)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblAdjustment>()
                .Property(e => e.TaxPct2)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblAdjustment>()
                .Property(e => e.TaxPct3)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblAdjustment>()
                .Property(e => e.AmountPlusTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblAdjustment>()
                .HasMany(e => e.tblTransactions)
                .WithOptional(e => e.tblAdjustment)
                .HasForeignKey(e => e.TenderID);

            modelBuilder.Entity<tblBatchCommSumm>()
                .Property(e => e.CommAmtOrig)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBatchCommSumm>()
                .Property(e => e.CommAmtAdd)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBatchJobProduct>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBatchJobProduct>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBatchJobProduct>()
                .Property(e => e.ServConCovChrg)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBatchJobProduct>()
                .Property(e => e.TaxRate1)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblBatchJobProduct>()
                .Property(e => e.TaxRate2)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblBatchJobProduct>()
                .Property(e => e.TaxRate3)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblBatchJobProduct>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBatchJobProduct>()
                .Property(e => e.ServConCovQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBatchJobProduct>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblBatchJobProduct>()
                .HasMany(e => e.lnkInventories)
                .WithRequired(e => e.tblBatchJobProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblBatchJobProduct>()
                .HasMany(e => e.tblCompleteProducts)
                .WithRequired(e => e.tblBatchJobProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblBatchJobProduct>()
                .HasMany(e => e.tblSchedProds)
                .WithRequired(e => e.tblBatchJobProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblBatchJob>()
                .Property(e => e.BudgPayCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBatchJob>()
                .Property(e => e.BudgProdCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBatchJob>()
                .Property(e => e.BudgCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBatchJob>()
                .Property(e => e.BudgChargeTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBatchJob>()
                .HasMany(e => e.tblBatchCommSumms)
                .WithRequired(e => e.tblBatchJob)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblBatchJob>()
                .HasMany(e => e.tblPOes)
                .WithRequired(e => e.tblBatchJob)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblBatchJob>()
                .HasMany(e => e.tblSchedules)
                .WithRequired(e => e.tblBatchJob)
                .HasForeignKey(e => e.BatchJobID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblBatchJob>()
                .HasMany(e => e.tblTransactions)
                .WithRequired(e => e.tblBatchJob)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblBatchJobService>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBatchJobService>()
                .Property(e => e.ServConCovChrg)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBatchJobService>()
                .Property(e => e.TaxRate1)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblBatchJobService>()
                .Property(e => e.TaxRate2)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblBatchJobService>()
                .Property(e => e.TaxRate3)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblBatchJobService>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBatchJobService>()
                .Property(e => e.ServConCovQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBatchJobService>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblBatchJobService>()
                .HasMany(e => e.tblCompleteServices)
                .WithRequired(e => e.tblBatchJobService)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblBatchJobService>()
                .HasMany(e => e.tblSchedServices)
                .WithRequired(e => e.tblBatchJobService)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblBonusRule>()
                .Property(e => e.MinRevenue)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBonusRule>()
                .Property(e => e.MinRevenuePct)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBonusRule>()
                .Property(e => e.FlatAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBonusRule>()
                .Property(e => e.FlatAmountPct)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBonusRule>()
                .Property(e => e.Percentage)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBranch>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblBranch>()
                .Property(e => e.RoyaltyRate1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBranch>()
                .Property(e => e.RoyaltyRate2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBranch>()
                .HasMany(e => e.lkpProducts)
                .WithOptional(e => e.tblBranch)
                .HasForeignKey(e => e.OrganisationID);

            modelBuilder.Entity<tblBranch>()
                .HasMany(e => e.lkpServices)
                .WithOptional(e => e.tblBranch)
                .HasForeignKey(e => e.OrganisationID);

            modelBuilder.Entity<tblBranch>()
                .HasMany(e => e.lkpTaxCodes)
                .WithRequired(e => e.tblBranch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblBranch>()
                .HasMany(e => e.lnkBranchProfiles)
                .WithRequired(e => e.tblBranch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblBranch>()
                .HasMany(e => e.tblAdjustments)
                .WithRequired(e => e.tblBranch)
                .HasForeignKey(e => e.LocationBranchID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblBranch>()
                .HasMany(e => e.tblTransactions)
                .WithOptional(e => e.tblBranch)
                .HasForeignKey(e => e.ServicingBranchID);

            modelBuilder.Entity<tblBranch>()
                .HasMany(e => e.tblCapAdjusts)
                .WithRequired(e => e.tblBranch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblBranch>()
                .HasMany(e => e.tblTasks)
                .WithRequired(e => e.tblBranch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblBranch>()
                .HasMany(e => e.tblTeams)
                .WithRequired(e => e.tblBranch)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblBranch>()
                .HasMany(e => e.tblTenders)
                .WithRequired(e => e.tblBranch)
                .HasForeignKey(e => e.LocationBranchID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCallCmd>()
                .HasMany(e => e.tblCallCmdProps)
                .WithRequired(e => e.tblCallCmd)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCallFieldSet>()
                .HasMany(e => e.tblCallCmds)
                .WithRequired(e => e.tblCallFieldSet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCallFieldSet>()
                .HasMany(e => e.tblCallFields)
                .WithRequired(e => e.tblCallFieldSet)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCallType>()
                .HasMany(e => e.tblCallCmds)
                .WithRequired(e => e.tblCallType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCancellation>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblCapSlot>()
                .HasMany(e => e.tblCapAdjusts)
                .WithRequired(e => e.tblCapSlot)
                .HasForeignKey(e => e.LinkID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCapWindow>()
                .HasMany(e => e.tblCapAdjusts)
                .WithRequired(e => e.tblCapWindow)
                .HasForeignKey(e => e.LinkID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblChrgAppl>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblChrgAppl>()
                .Property(e => e.Subtotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblChrgAppl>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblChrgAppl>()
                .Property(e => e.Tax1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblChrgAppl>()
                .Property(e => e.Tax2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblChrgAppl>()
                .Property(e => e.Tax3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblChrgAppl>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblChrgAppl>()
                .Property(e => e.ServConCovChrg)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblChrgAppl>()
                .Property(e => e.Charge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblChrgAppl>()
                .Property(e => e.ServConCovQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCommProduct>()
                .Property(e => e.Amount)
                .HasPrecision(10, 4);

            modelBuilder.Entity<tblCommService>()
                .Property(e => e.Amount)
                .HasPrecision(10, 4);

            modelBuilder.Entity<tblCompleteJobType>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompleteJobType>()
                .Property(e => e.Tax1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompleteJobType>()
                .Property(e => e.Tax2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompleteJobType>()
                .Property(e => e.Tax3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompleteJobType>()
                .HasMany(e => e.tblCompleteQuoteGroups)
                .WithRequired(e => e.tblCompleteJobType)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCompleteMisc>()
                .Property(e => e.Charge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompleteMisc>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblCompleteProduct>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompleteProduct>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompleteProduct>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblCompleteProduct>()
                .Property(e => e.ServConCovChrg)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompleteProduct>()
                .Property(e => e.TaxRate1)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblCompleteProduct>()
                .Property(e => e.TaxRate2)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblCompleteProduct>()
                .Property(e => e.TaxRate3)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblCompleteProduct>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompleteProduct>()
                .Property(e => e.ServConCovQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompleteProduct>()
                .HasMany(e => e.lnkInventories)
                .WithRequired(e => e.tblCompleteProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCompleteQuoteGroup>()
                .Property(e => e.CompRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompleteQuoteGroup>()
                .Property(e => e.AdjRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompleteQuoteGroup>()
                .Property(e => e.AdjTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompleteService>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompleteService>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblCompleteService>()
                .Property(e => e.ServConCovChrg)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompleteService>()
                .Property(e => e.TaxRate1)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblCompleteService>()
                .Property(e => e.TaxRate2)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblCompleteService>()
                .Property(e => e.TaxRate3)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblCompleteService>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompleteService>()
                .Property(e => e.ServConCovQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompProfile>()
                .HasMany(e => e.lnkBranchProfiles)
                .WithRequired(e => e.tblCompProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCompProfile>()
                .HasMany(e => e.lnkRegionProfiles)
                .WithRequired(e => e.tblCompProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCompProfile>()
                .HasMany(e => e.tblCustomers)
                .WithRequired(e => e.tblCompProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCompProfile>()
                .HasMany(e => e.tblSchedules)
                .WithRequired(e => e.tblCompProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCompProfile>()
                .HasMany(e => e.tblTransactions)
                .WithRequired(e => e.tblCompProfile)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCompTimeBlock>()
                .Property(e => e.MiscAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompTimeBlock>()
                .Property(e => e.TipAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompTimeBlock>()
                .Property(e => e.BaseRate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompTimeBlock>()
                .Property(e => e.CommAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCompTimeBlock>()
                .Property(e => e.BaseCostAmt)
                .HasPrecision(37, 10);

            modelBuilder.Entity<tblContact>()
                .Property(e => e.Phone1A)
                .IsUnicode(false);

            modelBuilder.Entity<tblContact>()
                .Property(e => e.Phone1)
                .IsUnicode(false);

            modelBuilder.Entity<tblContact>()
                .Property(e => e.Phone2A)
                .IsUnicode(false);

            modelBuilder.Entity<tblContact>()
                .Property(e => e.Phone2)
                .IsUnicode(false);

            modelBuilder.Entity<tblContact>()
                .Property(e => e.Phone3A)
                .IsUnicode(false);

            modelBuilder.Entity<tblContact>()
                .Property(e => e.Phone3)
                .IsUnicode(false);

            modelBuilder.Entity<tblContact>()
                .Property(e => e.Phone4A)
                .IsUnicode(false);

            modelBuilder.Entity<tblContact>()
                .Property(e => e.Phone4)
                .IsUnicode(false);

            modelBuilder.Entity<tblContact>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblCustomerNote>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblCustomer>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblCustomer>()
                .Property(e => e.ContIntUnits_Mail)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblCustomer>()
                .Property(e => e.ContIntUnits_Voice)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblCustomer>()
                .Property(e => e.ContIntUnits_Email)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblCustomer>()
                .Property(e => e.AlertCreditLimitAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblCustomer>()
                .HasMany(e => e.lnkInventories)
                .WithRequired(e => e.tblCustomer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCustomer>()
                .HasMany(e => e.tblAdjustments)
                .WithRequired(e => e.tblCustomer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCustomer>()
                .HasMany(e => e.tblCustomerNotes)
                .WithOptional(e => e.tblCustomer)
                .HasForeignKey(e => e.CustomerID);

            modelBuilder.Entity<tblCustomer>()
                .HasMany(e => e.tblCustomerNotes1)
                .WithOptional(e => e.tblCustomer1)
                .HasForeignKey(e => e.CustomerID);

            modelBuilder.Entity<tblCustomer>()
                .HasMany(e => e.tblDroppedInvoices)
                .WithRequired(e => e.tblCustomer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCustomer>()
                .HasMany(e => e.tblInquiries)
                .WithRequired(e => e.tblCustomer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCustomer>()
                .HasMany(e => e.tblInvoices)
                .WithRequired(e => e.tblCustomer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCustomer>()
                .HasMany(e => e.tblOSEquips)
                .WithRequired(e => e.tblCustomer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCustomer>()
                .HasMany(e => e.tblPOes)
                .WithRequired(e => e.tblCustomer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCustomer>()
                .HasMany(e => e.tblQuotes)
                .WithRequired(e => e.tblCustomer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblCustomer>()
                .HasMany(e => e.tblWebEvents)
                .WithRequired(e => e.tblCustomer)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblDeposit>()
                .Property(e => e.DepositTotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblDeposit>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblDeposit>()
                .HasMany(e => e.tblTenders)
                .WithRequired(e => e.tblDeposit)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblDispatchJobNote>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblDroppedInvoice>()
                .Property(e => e.TotalCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblDroppedInvoice>()
                .Property(e => e.Tax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblEmpLossTeam>()
                .HasMany(e => e.tblEmpLossTeamLinks)
                .WithRequired(e => e.tblEmpLossTeam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblEmployeeNote>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblEmployee>()
                .Property(e => e.Salary)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblEmployee>()
                .Property(e => e.HourPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblEmployee>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblEmployee>()
                .Property(e => e.MinimumPay)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblEmployee>()
                .HasMany(e => e.tblBatchCommSumms)
                .WithRequired(e => e.tblEmployee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblEmployee>()
                .HasMany(e => e.tblCommProducts)
                .WithRequired(e => e.tblEmployee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblEmployee>()
                .HasMany(e => e.tblCompTimeBlocks)
                .WithRequired(e => e.tblEmployee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblEmployee>()
                .HasMany(e => e.tblDispatchEmpWorkHours)
                .WithRequired(e => e.tblEmployee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblEmployee>()
                .HasMany(e => e.tblEmpLossTeamLinks)
                .WithRequired(e => e.tblEmployee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblEmployee>()
                .HasMany(e => e.tblPayChecks)
                .WithRequired(e => e.tblEmployee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblEmployee>()
                .HasMany(e => e.tblPayrollAdjs)
                .WithRequired(e => e.tblEmployee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblEmployee>()
                .HasMany(e => e.tblTimeCards)
                .WithRequired(e => e.tblEmployee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblEmployee>()
                .HasMany(e => e.tblWebEvents)
                .WithRequired(e => e.tblEmployee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblEmployeeSignout>()
                .Property(e => e.ReplacementCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblEmployeeSignout>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblFranchise>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblHoliday>()
                .HasMany(e => e.lnkHolidayAssigns)
                .WithRequired(e => e.tblHoliday)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblInvAdjAcct>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblInvAdjAcct>()
                .Property(e => e.Value)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblInvAvgCost>()
                .Property(e => e.ValInStock)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblInvAvgCost>()
                .Property(e => e.QtyInStock)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblInvAvgCost>()
                .Property(e => e.MiscValInStock)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblInvoiceProduct>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblInvoiceProduct>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblInvoiceProduct>()
                .Property(e => e.ServConCovChrg)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblInvoiceProduct>()
                .Property(e => e.TaxRate1)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblInvoiceProduct>()
                .Property(e => e.TaxRate2)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblInvoiceProduct>()
                .Property(e => e.TaxRate3)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblInvoiceProduct>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblInvoiceProduct>()
                .Property(e => e.ServConCovQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblInvoiceProduct>()
                .Property(e => e.Concentration)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblInvoiceProduct>()
                .HasMany(e => e.lnkInventories)
                .WithRequired(e => e.tblInvoiceProduct)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblInvoice>()
                .HasMany(e => e.tblChrgAppls)
                .WithRequired(e => e.tblInvoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblInvoice>()
                .HasMany(e => e.tblDroppedInvoices)
                .WithRequired(e => e.tblInvoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblInvoice>()
                .HasMany(e => e.lnkQBInvoiceExports)
                .WithRequired(e => e.tblInvoice)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblInvoiceService>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblInvoiceService>()
                .Property(e => e.ServConCovChrg)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblInvoiceService>()
                .Property(e => e.TaxRate1)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblInvoiceService>()
                .Property(e => e.TaxRate2)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblInvoiceService>()
                .Property(e => e.TaxRate3)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblInvoiceService>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblInvoiceService>()
                .Property(e => e.ServConCovQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblInvTransTicket>()
                .HasMany(e => e.tblInvTransfers)
                .WithRequired(e => e.tblInvTransTicket)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblJob>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblJob>()
                .Property(e => e.BudgPayCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblJob>()
                .Property(e => e.BudgProdCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblJob>()
                .Property(e => e.BudgCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblJob>()
                .Property(e => e.BudgChargeTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblJob>()
                .HasMany(e => e.lnkInventories)
                .WithRequired(e => e.tblJob)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblJob>()
                .HasMany(e => e.lnkNSInventories)
                .WithRequired(e => e.tblJob)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblJob>()
                .HasMany(e => e.tblEmpLossTeams)
                .WithRequired(e => e.tblJob)
                .HasForeignKey(e => e.LastCompJobID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblJob>()
                .HasMany(e => e.tblPOes)
                .WithRequired(e => e.tblJob)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblJob>()
                .HasMany(e => e.tblRefunds)
                .WithRequired(e => e.tblJob)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblJob>()
                .HasMany(e => e.tblTenders)
                .WithOptional(e => e.tblJob)
                .HasForeignKey(e => e.CompletionJobID);

            modelBuilder.Entity<tblKitInstance>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblKitInstance>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblLocation>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblLocation>()
                .HasMany(e => e.lnkInventories)
                .WithRequired(e => e.tblLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblLocation>()
                .HasMany(e => e.tblContacts)
                .WithRequired(e => e.tblLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblLocation>()
                .HasMany(e => e.tblOSEquips)
                .WithRequired(e => e.tblLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblLocation>()
                .HasMany(e => e.tblPOes)
                .WithRequired(e => e.tblLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblLocation>()
                .HasMany(e => e.tblServContracts)
                .WithRequired(e => e.tblLocation)
                .HasForeignKey(e => e.TaxLocationID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrganisation>()
                .Property(e => e.ApplicationName)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblOrganisation>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblOrganisation>()
                .Property(e => e.RoyaltyRate1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblOrganisation>()
                .Property(e => e.RoyaltyRate2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblOrganisation>()
                .HasMany(e => e.lkpBanks)
                .WithRequired(e => e.tblOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrganisation>()
                .HasMany(e => e.lkpBillPayers)
                .WithRequired(e => e.tblOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrganisation>()
                .HasMany(e => e.lkpInventoryReturnCodes)
                .WithRequired(e => e.tblOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrganisation>()
                .HasMany(e => e.lkpJobSubStatus)
                .WithRequired(e => e.tblOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrganisation>()
                .HasMany(e => e.lkpQuoteGroups)
                .WithRequired(e => e.tblOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrganisation>()
                .HasMany(e => e.lkpQuoteItems)
                .WithRequired(e => e.tblOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrganisation>()
                .HasMany(e => e.lkpQuoteJobTypes)
                .WithRequired(e => e.tblOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrganisation>()
                .HasMany(e => e.lkpSchedEventTypes)
                .WithRequired(e => e.tblOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrganisation>()
                .HasMany(e => e.lkpSuppliers)
                .WithRequired(e => e.tblOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrganisation>()
                .HasMany(e => e.lkpTaxCodes)
                .WithRequired(e => e.tblOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrganisation>()
                .HasMany(e => e.lkpZonePricings)
                .WithRequired(e => e.tblOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrganisation>()
                .HasMany(e => e.lnkOrgCustPayTypes)
                .WithRequired(e => e.tblOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrganisation>()
                .HasMany(e => e.tblCompProfiles)
                .WithRequired(e => e.tblOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrganisation>()
                .HasMany(e => e.tblInvTransTickets)
                .WithRequired(e => e.tblOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrganisation>()
                .HasMany(e => e.tblPOes)
                .WithRequired(e => e.tblOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrganisation>()
                .HasMany(e => e.tblQuotes)
                .WithRequired(e => e.tblOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrganisation>()
                .HasMany(e => e.tblStockLocations)
                .WithRequired(e => e.tblOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOrganisation>()
                .HasMany(e => e.tblTasks)
                .WithRequired(e => e.tblOrganisation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOSEquip>()
                .HasMany(e => e.lnkServConLineEquips)
                .WithRequired(e => e.tblOSEquip)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblOSEquip>()
                .HasMany(e => e.tblOSEquip1)
                .WithRequired(e => e.tblOSEquip2)
                .HasForeignKey(e => e.OrigEquipID);

            modelBuilder.Entity<tblPaycheckDetail>()
                .Property(e => e.Quantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPaycheckDetail>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPaycheckDetail>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPayCheck>()
                .HasMany(e => e.tblBatchCommSumms)
                .WithRequired(e => e.tblPayCheck)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPayCheck>()
                .HasMany(e => e.tblPaycheckDetails)
                .WithRequired(e => e.tblPayCheck)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPayCheck>()
                .HasMany(e => e.tblPayrollAdjs)
                .WithRequired(e => e.tblPayCheck)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPayrollAdj>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPO>()
                .Property(e => e.TotalCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPO>()
                .Property(e => e.TotalTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPO>()
                .Property(e => e.TaxPct)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblPO>()
                .Property(e => e.TotalChargeReceived)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPO>()
                .Property(e => e.TotalTaxReceived)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPO>()
                .Property(e => e.TotalShippingHandling)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPO>()
                .HasMany(e => e.tblPOHistories)
                .WithRequired(e => e.tblPO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPO>()
                .HasMany(e => e.tblPOItems)
                .WithRequired(e => e.tblPO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPO>()
                .HasMany(e => e.tblPOMiscItems)
                .WithRequired(e => e.tblPO)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPOItem>()
                .Property(e => e.UnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPOItem>()
                .Property(e => e.Tax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPOItem>()
                .Property(e => e.UnitCostReceived)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPOItem>()
                .Property(e => e.MiscDistribCostTot)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPOItem>()
                .Property(e => e.TaxPct)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblPOItem>()
                .Property(e => e.TaxReceived)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPOItem>()
                .HasMany(e => e.lnkInventories)
                .WithRequired(e => e.tblPOItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblPOItem>()
                .HasMany(e => e.tblPOItemIntents)
                .WithRequired(e => e.tblPOItem)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblQBExport>()
                .HasMany(e => e.tblDeposits)
                .WithRequired(e => e.tblQBExport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblQBExport>()
                .HasMany(e => e.tblInvAdjAccts)
                .WithRequired(e => e.tblQBExport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblQBExport>()
                .HasMany(e => e.lnkQBInvoiceExports)
                .WithRequired(e => e.tblQBExport)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblQuote>()
                .HasMany(e => e.tblCompleteJobTypes)
                .WithRequired(e => e.tblQuote)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblQuote>()
                .HasMany(e => e.tblCompleteQuoteItems)
                .WithRequired(e => e.tblQuote)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblRefund>()
                .Property(e => e.TaxAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblRefund>()
                .Property(e => e.TotalAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblRefund>()
                .Property(e => e.CustomerAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblRefund>()
                .Property(e => e.SupplierAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblRefundItem>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblRefundItem>()
                .Property(e => e.CustomerRefund)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblRefundItem>()
                .Property(e => e.SupplierRefund)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblRefundItem>()
                .Property(e => e.Tax1Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblRefundItem>()
                .Property(e => e.Tax2Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblRefundItem>()
                .Property(e => e.Tax3Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblRegion>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblRegion>()
                .Property(e => e.RoyaltyRate1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblRegion>()
                .Property(e => e.RoyaltyRate2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblRegion>()
                .HasMany(e => e.lkpTaxCodes)
                .WithRequired(e => e.tblRegion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblRegion>()
                .HasMany(e => e.lnkRegionProfiles)
                .WithRequired(e => e.tblRegion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblRegion>()
                .HasMany(e => e.tblTasks)
                .WithRequired(e => e.tblRegion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblReturn>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblReturn>()
                .Property(e => e.QtyReinstated)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblReturn>()
                .Property(e => e.ReturnToVendorRefund)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSchedProd>()
                .Property(e => e.Price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSchedProd>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSchedProd>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblSchedProd>()
                .Property(e => e.ServConCovChrg)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSchedProd>()
                .Property(e => e.TaxRate1)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblSchedProd>()
                .Property(e => e.TaxRate2)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblSchedProd>()
                .Property(e => e.TaxRate3)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblSchedProd>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSchedProd>()
                .Property(e => e.ServConCovQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSchedProd>()
                .HasMany(e => e.lnkInventories)
                .WithRequired(e => e.tblSchedProd)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSchedService>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSchedService>()
                .Property(e => e.Originator)
                .IsUnicode(false);

            modelBuilder.Entity<tblSchedService>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblSchedService>()
                .Property(e => e.ServConCovChrg)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSchedService>()
                .Property(e => e.TaxRate1)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblSchedService>()
                .Property(e => e.TaxRate2)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblSchedService>()
                .Property(e => e.TaxRate3)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblSchedService>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSchedService>()
                .Property(e => e.ServConCovQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSchedule>()
                .Property(e => e.TotalCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSchedule>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblSchedule>()
                .Property(e => e.BudgPayCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSchedule>()
                .Property(e => e.BudgProdCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSchedule>()
                .Property(e => e.BudgCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSchedule>()
                .Property(e => e.BudgChargeTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSchedule>()
                .HasMany(e => e.lnkDocs)
                .WithOptional(e => e.tblSchedule)
                .HasForeignKey(e => e.ScheduleID);

            modelBuilder.Entity<tblSchedule>()
                .HasMany(e => e.lnkDocs1)
                .WithOptional(e => e.tblSchedule1)
                .HasForeignKey(e => e.EstimateID);

            modelBuilder.Entity<tblSchedule>()
                .HasMany(e => e.tblBatchJobs)
                .WithRequired(e => e.tblSchedule)
                .HasForeignKey(e => e.MasterScheduleID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSchedule>()
                .HasMany(e => e.tblEmpLossTeams)
                .WithRequired(e => e.tblSchedule)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSchedule>()
                .HasMany(e => e.tblEstNotes)
                .WithRequired(e => e.tblSchedule)
                .HasForeignKey(e => e.EstimateID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSchedule>()
                .HasMany(e => e.tblSchedules1)
                .WithRequired(e => e.tblSchedule1)
                .HasForeignKey(e => e.EstimateID);

            modelBuilder.Entity<tblSchedule>()
                .HasMany(e => e.tblWebJobNotes)
                .WithRequired(e => e.tblSchedule)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSchedule>()
                .HasMany(e => e.tblSchedules11)
                .WithRequired(e => e.tblSchedule2)
                .HasForeignKey(e => e.OrigSchedID);

            modelBuilder.Entity<tblServConLine>()
                .Property(e => e.Rate)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblServConLine>()
                .Property(e => e.CoverageAmount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblServConLine>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblServConLine>()
                .HasMany(e => e.lnkServConLineEquips)
                .WithRequired(e => e.tblServConLine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblServConLine>()
                .HasMany(e => e.lnkServConLinePS)
                .WithRequired(e => e.tblServConLine)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblServContract>()
                .Property(e => e.TotalCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblServContract>()
                .Property(e => e.TotalTax1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblServContract>()
                .Property(e => e.TotalTax2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblServContract>()
                .Property(e => e.TotalTax3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblServContract>()
                .Property(e => e.TaxPct1)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblServContract>()
                .Property(e => e.TaxPct2)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblServContract>()
                .Property(e => e.TaxPct3)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblServContract>()
                .HasMany(e => e.tblServConLines)
                .WithRequired(e => e.tblServContract)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSkillInstance>()
                .Property(e => e.Qty)
                .HasPrecision(8, 4);

            modelBuilder.Entity<tblStockLocation>()
                .HasMany(e => e.tblInvTransfers)
                .WithOptional(e => e.tblStockLocation)
                .HasForeignKey(e => e.SourceStockLocationID);

            modelBuilder.Entity<tblStockLocation>()
                .HasMany(e => e.tblInvTransfers1)
                .WithOptional(e => e.tblStockLocation1)
                .HasForeignKey(e => e.DestinationStockLocationID);

            modelBuilder.Entity<tblStockLocation>()
                .HasMany(e => e.tblInvTransTickets)
                .WithOptional(e => e.tblStockLocation)
                .HasForeignKey(e => e.DefaultStockLocationID);

            modelBuilder.Entity<tblStockLocation>()
                .HasMany(e => e.tblPOes)
                .WithOptional(e => e.tblStockLocation)
                .HasForeignKey(e => e.ShipToStockLocationID);

            modelBuilder.Entity<tblStockLocation>()
                .HasMany(e => e.tblSubStockLocations)
                .WithRequired(e => e.tblStockLocation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSupplierCatalog>()
                .Property(e => e.UnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSupplierCatalog>()
                .Property(e => e.SellPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblSupplierCatalog>()
                .HasMany(e => e.lnkInventories)
                .WithRequired(e => e.tblSupplierCatalog)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblSupplierCatalog>()
                .HasMany(e => e.tblPOItems)
                .WithRequired(e => e.tblSupplierCatalog)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTask>()
                .Property(e => e.RSUnits)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblTask>()
                .Property(e => e.AlarmUnits)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblTask>()
                .Property(e => e.RecTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<tblTask>()
                .HasMany(e => e.lnkTaskAssigns)
                .WithRequired(e => e.tblTask)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTask>()
                .HasMany(e => e.tblTaskNotes)
                .WithRequired(e => e.tblTask)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTaskSched>()
                .Property(e => e.Recycle)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblTaskSched>()
                .Property(e => e.RSUnits)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblTaskSched>()
                .Property(e => e.AlarmUnits)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<tblTaskSched>()
                .HasMany(e => e.tblTasks)
                .WithRequired(e => e.tblTaskSched)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTeam>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblTeam>()
                .HasMany(e => e.tblEmpLossTeams)
                .WithRequired(e => e.tblTeam)
                .HasForeignKey(e => e.NewTeamID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTeam>()
                .HasMany(e => e.tblEmpLossTeams1)
                .WithRequired(e => e.tblTeam1)
                .HasForeignKey(e => e.OrigTeamID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTeam>()
                .HasMany(e => e.tblTransactions)
                .WithRequired(e => e.tblTeam)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblTender>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblTender>()
                .Property(e => e.Tip)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblTransaction>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblTransaction>()
                .Property(e => e.Tip)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblTransaction>()
                .Property(e => e.Tax1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblTransaction>()
                .Property(e => e.AddOnCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblTransaction>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblTransaction>()
                .Property(e => e.Tax2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblTransaction>()
                .Property(e => e.Tax3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblTransaction>()
                .Property(e => e.TaxRate1)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblTransaction>()
                .Property(e => e.TaxRate2)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblTransaction>()
                .Property(e => e.TaxRate3)
                .HasPrecision(6, 3);

            modelBuilder.Entity<tblUserGroup>()
                .HasMany(e => e.tblUserGroupLinks)
                .WithRequired(e => e.tblUserGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUserGroup>()
                .HasMany(e => e.tblUserGroupRightLinks)
                .WithRequired(e => e.tblUserGroup)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUserSecurity>()
                .HasMany(e => e.tblInquiries)
                .WithRequired(e => e.tblUserSecurity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUserSecurity>()
                .HasMany(e => e.tblPayrollAdjs)
                .WithRequired(e => e.tblUserSecurity)
                .HasForeignKey(e => e.SavedByLoginID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUserSecurity>()
                .HasMany(e => e.tblTimeCards)
                .WithRequired(e => e.tblUserSecurity)
                .HasForeignKey(e => e.SavedByLoginID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUserSecurity>()
                .HasMany(e => e.tblUserGroupLinks)
                .WithRequired(e => e.tblUserSecurity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblUserSecurity>()
                .HasMany(e => e.tblWebEvents)
                .WithRequired(e => e.tblUserSecurity)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblVersion>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<tblVersion>()
                .Property(e => e.ClientVersion)
                .IsUnicode(false);

            modelBuilder.Entity<tblVersion>()
                .HasMany(e => e.sysValidatorLogs)
                .WithRequired(e => e.tblVersion)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<lnkTeamAppointment>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<lnkTeamCategory>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<lnkTeamCustomer>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<lnkTeamSubStatu>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();

            modelBuilder.Entity<MD_AssignedInventory>()
                .Property(e => e.Bin)
                .IsUnicode(false);

            modelBuilder.Entity<MD_AssignedInventory>()
                .Property(e => e.decQuantityUsed)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_AssignedInventory>()
                .Property(e => e.txtStockLocName)
                .IsUnicode(false);

            modelBuilder.Entity<MD_AssignedInventory>()
                .Property(e => e.txtDesc)
                .IsUnicode(false);

            modelBuilder.Entity<MD_AssignedInventory>()
                .Property(e => e.txtSerialNum)
                .IsUnicode(false);

            modelBuilder.Entity<MD_AssignedInventory>()
                .Property(e => e.decQuantityCore)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_AssignedInventory>()
                .Property(e => e.curUnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_AssignedInventory>()
                .Property(e => e.curUnitSellPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_NewInventory>()
                .Property(e => e.txtStockLocName)
                .IsUnicode(false);

            modelBuilder.Entity<MD_NewInventory>()
                .Property(e => e.txtIntPartNum)
                .IsUnicode(false);

            modelBuilder.Entity<MD_NewInventory>()
                .Property(e => e.txtProductName)
                .IsUnicode(false);

            modelBuilder.Entity<MD_NewInventory>()
                .Property(e => e.txtVendor)
                .IsUnicode(false);

            modelBuilder.Entity<MD_NewInventory>()
                .Property(e => e.txtVendorPartNum)
                .IsUnicode(false);

            modelBuilder.Entity<MD_NewInventory>()
                .Property(e => e.decQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_NewInventory>()
                .Property(e => e.decUnitFactor)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_NewInventory>()
                .Property(e => e.curUnitCost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_NewInventory>()
                .Property(e => e.curSellPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_NewInventory>()
                .Property(e => e.txtSerialNum)
                .IsUnicode(false);

            modelBuilder.Entity<MD_NewInventory>()
                .Property(e => e.decTaxRate1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_NewInventory>()
                .Property(e => e.decTaxRate2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_NewInventory>()
                .Property(e => e.decTaxRate3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_NewInventory>()
                .Property(e => e.LoginID)
                .IsUnicode(false);

            modelBuilder.Entity<MD_NewInventory>()
                .Property(e => e.txtNotes)
                .IsUnicode(false);

            modelBuilder.Entity<MD_tblJobs>()
                .Property(e => e.decArriveWindow)
                .HasPrecision(4, 2);

            modelBuilder.Entity<MD_tblJobs>()
                .Property(e => e.decDuration)
                .HasPrecision(5, 2);

            modelBuilder.Entity<MD_tblJobs>()
                .Property(e => e.decTaxRate1)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_tblJobs>()
                .Property(e => e.decTaxRate2)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_tblJobs>()
                .Property(e => e.decTaxRate3)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_tblJobs>()
                .Property(e => e.curAcctBalance)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_tblJobs>()
                .Property(e => e.txtDefaultOSEquipDesc)
                .IsUnicode(false);

            modelBuilder.Entity<MD_tblJobs>()
                .Property(e => e.txtDefaultServConDesc)
                .IsUnicode(false);

            modelBuilder.Entity<MD_tblJobs>()
                .Property(e => e.txtJobDesc)
                .IsUnicode(false);

            modelBuilder.Entity<MD_tblJobs>()
                .Property(e => e.txtJobNum)
                .IsUnicode(false);

            modelBuilder.Entity<MD_tblPayment>()
                .Property(e => e.curPaymentAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_tblPayment>()
                .Property(e => e.curTipAmt)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_tblPayment>()
                .Property(e => e.txtNotes)
                .IsUnicode(false);

            modelBuilder.Entity<MD_tblPaymentDetails>()
                .Property(e => e.txtTendPropValue)
                .IsUnicode(false);

            modelBuilder.Entity<MD_tblPayroll>()
                .Property(e => e.txtNotes)
                .IsUnicode(false);

            modelBuilder.Entity<MD_tblProductCharges>()
                .Property(e => e.txtPartNum)
                .IsUnicode(false);

            modelBuilder.Entity<MD_tblProductCharges>()
                .Property(e => e.txtProductName)
                .IsUnicode(false);

            modelBuilder.Entity<MD_tblProductCharges>()
                .Property(e => e.decQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_tblProductCharges>()
                .Property(e => e.curSellPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_tblProductCharges>()
                .Property(e => e.decServConCovQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_tblProductCharges>()
                .Property(e => e.curServConCovChrg)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_tblProductCharges>()
                .Property(e => e.txtServConDesc)
                .IsUnicode(false);

            modelBuilder.Entity<MD_tblProductCharges>()
                .Property(e => e.txtOSEquipDesc)
                .IsUnicode(false);

            modelBuilder.Entity<MD_tblServiceCharges>()
                .Property(e => e.txtShortDesc)
                .IsUnicode(false);

            modelBuilder.Entity<MD_tblServiceCharges>()
                .Property(e => e.decQuantity)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_tblServiceCharges>()
                .Property(e => e.curUnitCharge)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_tblServiceCharges>()
                .Property(e => e.decServConCovQty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_tblServiceCharges>()
                .Property(e => e.curServConCovChrg)
                .HasPrecision(19, 4);

            modelBuilder.Entity<MD_tblServiceCharges>()
                .Property(e => e.txtServConDesc)
                .IsUnicode(false);

            modelBuilder.Entity<MD_tblServiceCharges>()
                .Property(e => e.txtOSEquipDesc)
                .IsUnicode(false);

            modelBuilder.Entity<tblBillingProp>()
                .Property(e => e.CreditLimit)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBillingProp>()
                .Property(e => e.RecTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<tblBillingSplit>()
                .Property(e => e.ServConCovChrg)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBillingSplit>()
                .Property(e => e.RecTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<tblBillingSplit>()
                .Property(e => e.Amount)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblBonu>()
                .Property(e => e.AmountPaid)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblEstimate>()
                .Property(e => e.RecTimeStamp)
                .IsFixedLength();

            modelBuilder.Entity<tblPOMiscItem>()
                .Property(e => e.Cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPOMiscItem>()
                .Property(e => e.Tax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblPOMiscItem>()
                .Property(e => e.Qty)
                .HasPrecision(19, 4);

            modelBuilder.Entity<tblTeamZone>()
                .Property(e => e.RecTimestamp)
                .IsFixedLength();
        }
    }
}

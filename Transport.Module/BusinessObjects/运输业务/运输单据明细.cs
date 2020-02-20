using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.Filtering;

namespace Transport.Module.BusinessObjects.运输业务
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    [XafDefaultProperty("运输单据明细")]
    public class 运输单据明细 : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).

        private 运输单据 _单据;
        [ModelDefault("AllowEdit", "False")]
        [Association("单据-明细"), DevExpress.Xpo.Aggregated]
        public 运输单据 单据
        {
            get { return _单据; }
            set { SetPropertyValue("单据", ref _单据, value); }
        }

        private bool _已作废;
        [ModelDefault("AllowEdit", "False")]
        [SearchMemberOptions(SearchMemberMode.Exclude)]
        public bool 已作废
        {
            get { return _已作废; }
            set { SetPropertyValue("已作废", ref _已作废, value); }
        }
        private 单据状态 _状态;
        [ModelDefault("AllowEdit", "False")]
        [SearchMemberOptions(SearchMemberMode.Exclude)]
        public 单据状态 状态
        {
            get { return _状态; }
            set { SetPropertyValue("状态", ref _状态, value); }
        }
        private DateTime _记录时间;

        [ModelDefault("AllowEdit", "False")]
        [SearchMemberOptions(SearchMemberMode.Exclude)]
        public DateTime 记录时间
        {
            get { return _记录时间; }
            set { SetPropertyValue("记录时间", ref _记录时间, value); }
        }

        private 基础信息.消费分类 _消费分类;
        public 基础信息.消费分类 消费分类
        {
            get { return _消费分类; }
            set { SetPropertyValue("消费分类", ref _消费分类, value); }
        }

        private decimal _费用;
        public decimal 费用
        {
            get { return _费用; }
            set { SetPropertyValue("费用", ref _费用, value); }
        }


        public 运输单据明细(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        //private string _PersistentProperty;
        //[XafDisplayName("My display name"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        //public string PersistentProperty {
        //    get { return _PersistentProperty; }
        //    set { SetPropertyValue(nameof(PersistentProperty), ref _PersistentProperty, value); }
        //}

        //[Action(Caption = "My UI Action", ConfirmationMessage = "Are you sure?", ImageName = "Attention", AutoCommit = true)]
        //public void ActionMethod() {
        //    // Trigger a custom business logic for the current record in the UI (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112619.aspx).
        //    this.PersistentProperty = "Paid";
        //}
    }
}
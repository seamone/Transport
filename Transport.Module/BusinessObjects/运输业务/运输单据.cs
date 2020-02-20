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
    [XafDisplayName("运输单据")]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    public class 运输单据 : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).

        private string _Code;
        [NonCloneable, RuleUniqueValue, Indexed(Unique = true)]
        [XafDisplayName("运输单号")]
        [ModelDefault("AllowEdit", "False")]
        public string Code
        {
            get { return _Code; }
            set { SetPropertyValue("Code", ref _Code, value); }
        }
        private bool _已作废;
        [ModelDefault("AllowEdit", "False")]
        [SearchMemberOptions(SearchMemberMode.Exclude)]
        public bool 已作废
        {
            get { return _已作废; }
            set { SetPropertyValue("已作废", ref _已作废, value); }
        }

        private DateTime _下单时间;
        [SearchMemberOptions(SearchMemberMode.Exclude)]

        [ModelDefault("AllowEdit", "False")]
        public DateTime 下单时间
        {
            get { return _下单时间; }
            set { SetPropertyValue("下单时间", ref _下单时间, value); }
        }


        private DateTime _出车时间;
        [SearchMemberOptions(SearchMemberMode.Exclude)]

        [ModelDefault("AllowEdit", "true")]
        public DateTime 出车时间
        {
            get { return _出车时间; }
            set { SetPropertyValue("出车时间", ref _出车时间, value); }
        }

        private DateTime _回车时间;
        [SearchMemberOptions(SearchMemberMode.Exclude)]

        [ModelDefault("AllowEdit", "true")]
        public DateTime 回车时间
        {
            get { return _出车时间; }
            set { SetPropertyValue("回车时间", ref _回车时间, value); }
        }


        private 基础信息.车辆信息 _车辆信息;
        public 基础信息.车辆信息 车辆信息
        {
            get { return _车辆信息; }
            set { SetPropertyValue("车辆信息", ref _车辆信息, value); }
        }

        private 基础信息.司机信息 _司机信息;
        public 基础信息.司机信息 司机信息
        {
            get { return _司机信息; }
            set { SetPropertyValue("司机信息", ref _司机信息, value); }
        }
        
        private decimal _出车总费;
        public decimal 出车总费
        {
            get { return _出车总费; }
            set { SetPropertyValue("出车总费", ref _出车总费, value); }
        }










        [Association("单据-明细"), DevExpress.Xpo.Aggregated]
        [SearchMemberOptions(SearchMemberMode.Exclude)]
        public XPCollection<运输单据明细> 明细
        {
            get
            {
                return GetCollection<运输单据明细>("明细");
            }
        }


        private string _Memo;
        [Size(-1)]
        [XafDisplayName("备注")]
        [SearchMemberOptions(SearchMemberMode.Exclude)]
        public string Memo
        {
            get { return _Memo; }
            set { SetPropertyValue("Memo", ref _Memo, value); }
        }














        public 运输单据(Session session)
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

    public enum 单据状态
    {
        新建 = 0,
        处理中 = 1,
        完成 = 2
    }

}
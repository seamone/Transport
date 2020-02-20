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

namespace Transport.Module.BusinessObjects.基础信息
{
    [DefaultClassOptions]
    //[ImageName("BO_Contact")]
    //[DefaultProperty("DisplayMemberNameForLookupEditorsOfThisType")]
    //[DefaultListViewOptions(MasterDetailMode.ListViewOnly, false, NewItemRowPosition.None)]
    //[Persistent("DatabaseTableName")]
    // Specify more UI options using a declarative approach (https://documentation.devexpress.com/#eXpressAppFramework/CustomDocument112701).
    [XafDefaultProperty("车牌号码")]
    public class 车辆信息 : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public 车辆信息(Session session) : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }
        
        private string _车牌号码;
        public string 车牌号码
        {
            get { return _车牌号码; }
            set { SetPropertyValue("车牌号码", ref _车牌号码, value); }
        }

        private 车型 _车型;
        public 车型 车型
        {
            get { return _车型; }
            set { SetPropertyValue("车型", ref _车型, value); }
        }

        //[BackReferenceProperty("车辆信息")]
        //IList<司机信息> 司机信息 { get; } = new List<司机信息>();

        private 司机信息 _司机信息;
        public 司机信息 司机信息
        {
            get { return _司机信息; }
            set { SetPropertyValue("司机信息", ref _司机信息, value); }
        }

        [XafDisplayName("备注")]
        private string _Memo;
        public string Memo
        {
            get { return _Memo; }
            set { SetPropertyValue("Memo", ref _Memo, value); }
        }
    }
}
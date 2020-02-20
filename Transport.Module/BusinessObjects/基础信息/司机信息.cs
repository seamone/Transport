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
    [XafDefaultProperty("司机信息")]
    public class 司机信息 : BaseObject
    { // Inherit from a different class to provide a custom primary key, concurrency and deletion behavior, etc. (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument113146.aspx).
        public 司机信息(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        [XafDisplayName("名称")]
        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { SetPropertyValue("Name", ref _Name, value); }
        }

        private 车辆信息 _车辆信息;
        public 车辆信息 车辆信息
        {
            get { return _车辆信息; }
            set { SetPropertyValue("车辆信息", ref _车辆信息, value); }
        }


        //[RuleRequiredField("手机号必填", DefaultContexts.Save)]
        private string _手机号码;
        public string 手机号码
        {
            get { return _手机号码; }
            set { SetPropertyValue("手机号码", ref _手机号码, value); }
        }

        private string _身份证号;
        public string 身份证号
        {
            get { return _身份证号; }
            set { SetPropertyValue("身份证号", ref _身份证号, value); }
        }

        private string _驾驶证号;
        public string 驾驶证号
        {
            get { return _驾驶证号; }
            set { SetPropertyValue("驾驶证号", ref _驾驶证号, value); }
        }

        private string _银行卡号;
        public string 银行卡号
        {
            get { return _银行卡号; }
            set { SetPropertyValue("银行卡号", ref _银行卡号, value); }
        }

        private string _持卡人;
        public string 持卡人
        {
            get { return _持卡人; }
            set { SetPropertyValue("持卡人", ref _持卡人, value); }
        }

    }
}
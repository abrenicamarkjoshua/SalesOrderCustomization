using System;
using System.Collections;
using System.Collections.Generic;
using PX.SM;
using PX.Data;
using PX.Objects.SO;
using PX.Objects.CR;
using PX.Objects.IN;
using PX.Objects.CS;
using PX.Objects.CM;
using PX.Objects.AP;

namespace SalesOrderCustomization
{
    public class SOLineExtension : PXCacheExtension<SOLine>
    {
        public abstract class attributeValue : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute Value")]
        public string AttributeValue { get; set; }
    }

    public class SOSiteStatusSelectedExtension : PXCacheExtension<SOSiteStatusSelected>
    {
        public abstract class attributeValue : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute Value")]
        public string AttributeValue { get; set; }
    }

    public class SOOrderEntryExt : PXGraphExtension<SOOrderEntry>
    {
        public class string_AttributeType : Constant<string>
        {
            public string_AttributeType() : base("COLOR") {; }
        }

        protected void SOLine_AttributeValue_FieldSelecting(PXCache sender, PXFieldSelectingEventArgs e)
        {
            if (e.Row == null) return;

            CSAnswers attr = PXSelect<CSAnswers,
                    Where<CSAnswers.entityID, Equal<Current<SOLine.inventoryID>>>>.SelectSingleBound(Base, new object[] { e.Row });
            if (attr != null)
            {
                e.ReturnValue = attr.Value;
            }
            e.ReturnState = PXStringState.CreateInstance(
                e.ReturnState, null, null, "AttributeValue",
                null, -1, null, null, null,
                false, null);
            (e.ReturnState as PXFieldState).Enabled = false;
        }

        protected void SOSiteStatusSelected_AttributeValue_FieldSelecting(PXCache sender, PXFieldSelectingEventArgs e)
        {
            if (e.Row == null) return;

            CSAnswers attr = PXSelect<CSAnswers,
                    Where<CSAnswers.entityID, Equal<Current<SOSiteStatusSelected.inventoryID>>>>.SelectSingleBound(Base, new object[] { e.Row });
            if (attr != null)
            {
                e.ReturnValue = attr.Value;
            }
        }
    }


}
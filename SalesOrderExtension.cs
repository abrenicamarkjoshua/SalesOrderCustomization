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
        #region AttributeID & Value 1
        public abstract class attributeValue1 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute Value 1")]
        public string AttributeValue1 { get; set; }

        public abstract class attributeID1 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute ID 1")]
        public string AttributeID1 { get; set; }
        #endregion AttributeID & value 1

        #region AttributeID & Value 2
        public abstract class attributeValue2 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute Value 2")]
        public string AttributeValue2 { get; set; }

        public abstract class attributeID2 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute ID 2")]
        public string AttributeID2 { get; set; }
        #endregion AttributeID & value 2

        #region AttributeID & Value 3
        public abstract class attributeValue3 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute Value 3")]
        public string AttributeValue3 { get; set; }

        public abstract class attributeID3 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute ID 3")]
        public string AttributeID3 { get; set; }
        #endregion AttributeID & value 3

        #region AttributeID & Value 4
        public abstract class attributeValue4 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute Value 4")]
        public string AttributeValue4 { get; set; }

        public abstract class attributeID4 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute ID 4")]
        public string AttributeID4 { get; set; }
        #endregion AttributeID & value 4

        #region AttributeID & Value 5
        public abstract class attributeValue5 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute Value 5")]
        public string AttributeValue5 { get; set; }

        public abstract class attributeID5 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute ID 5")]
        public string AttributeID5 { get; set; }
        #endregion AttributeID & value 5

        #region AttributeID & Value 6
        public abstract class attributeValue6 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute Value 6")]
        public string AttributeValue6 { get; set; }

        public abstract class attributeID6 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute ID 6")]
        public string AttributeID6 { get; set; }
        #endregion AttributeID & value 6
    }

    public class SOSiteStatusSelectedExtension : PXCacheExtension<SOSiteStatusSelected>
    {
        #region AttributeID & Value 1
        public abstract class attributeValue1 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute Value 1")]
        public string AttributeValue1 { get; set; }

        public abstract class attributeID1 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute ID 1")]
        public string AttributeID1 { get; set; }
        #endregion AttributeID & value 1

        #region AttributeID & Value 2
        public abstract class attributeValue2 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute Value 2")]
        public string AttributeValue2 { get; set; }

        public abstract class attributeID2 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute ID 2")]
        public string AttributeID2 { get; set; }
        #endregion AttributeID & value 2

        #region AttributeID & Value 3
        public abstract class attributeValue3 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute Value 3")]
        public string AttributeValue3 { get; set; }

        public abstract class attributeID3 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute ID 3")]
        public string AttributeID3 { get; set; }
        #endregion AttributeID & value 3

        #region AttributeID & Value 4
        public abstract class attributeValue4 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute Value 4")]
        public string AttributeValue4 { get; set; }

        public abstract class attributeID4 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute ID 4")]
        public string AttributeID4 { get; set; }
        #endregion AttributeID & value 4

        #region AttributeID & Value 5
        public abstract class attributeValue5 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute Value 5")]
        public string AttributeValue5 { get; set; }

        public abstract class attributeID5 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute ID 5")]
        public string AttributeID5 { get; set; }
        #endregion AttributeID & value 5

        #region AttributeID & Value 6
        public abstract class attributeValue6 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute Value 6")]
        public string AttributeValue6 { get; set; }

        public abstract class attributeID6 : IBqlField
        { }

        [PXString]
        [PXUIField(DisplayName = "Attribute ID 6")]
        public string AttributeID6 { get; set; }
        #endregion AttributeID & value 6

    }

    public class CSAttributeGroupExtension : PXCacheExtension<CSAttributeGroup>
    {
        [PXDBShort, PXUIField(DisplayName = "Attribute number")]
        public virtual short? SortOrder
        {
            get;
            set;
        }
    }
    public class SOOrderEntryExt : PXGraphExtension<SOOrderEntry>
    {
        #region constants
        public class int_1 : Constant<int>
        {
            public int_1() : base(1) {; }
        }
        public class int_2 : Constant<int>
        {
            public int_2() : base(2) {; }
        }
        public class int_3 : Constant<int>
        {
            public int_3() : base(3) {; }
        }
        public class int_4 : Constant<int>
        {
            public int_4() : base(4) {; }
        }
        public class int_5 : Constant<int>
        {
            public int_5() : base(5) {; }
        }
        public class int_6 : Constant<int>
        {
            public int_6() : base(6) {; }
        }
        #endregion constants

        //protected void SOLine_AttributeValue_FieldSelecting(PXCache sender, PXFieldSelectingEventArgs e)
        //{
        //    if (e.Row == null) return;

        //    CSAnswers attr = PXSelect<CSAnswers,
        //            Where<CSAnswers.entityID, Equal<Current<SOLine.inventoryID>>>>.SelectSingleBound(Base, new object[] { e.Row });


        //    if (attr != null)
        //    {
        //        e.ReturnValue = attr.Value;
        //    }
        //    e.ReturnState = PXStringState.CreateInstance(
        //        e.ReturnState, null, null, "AttributeValue",
        //        null, -1, null, null, null,
        //        false, null);
        //    (e.ReturnState as PXFieldState).Enabled = false;
        //}

        #region show attributeID & attributeValue 1
        protected void SOSiteStatusSelected_AttributeValue1_FieldSelecting(PXCache sender, PXFieldSelectingEventArgs e)
        {
            if (e.Row == null) return;

            CSAnswers attr = PXSelectJoin<CSAnswers,
                    LeftJoin<InventoryItem, On<CSAnswers.entityID, Equal<InventoryItem.inventoryID>>,
                    LeftJoin<CSAttributeGroup, On<CSAttributeGroup.entityClassID, Equal<InventoryItem.itemClassID>>>>,
                    Where<CSAttributeGroup.sortOrder, Equal<int_1>, And<CSAnswers.entityID, Equal<Current<SOSiteStatusSelected.inventoryID>>,
                    And<CSAttributeGroup.attributeID, Equal<CSAnswers.attributeID>>>>>.SelectSingleBound(Base, new object[] { e.Row });
            if (attr != null)
            {
                e.ReturnValue = attr.Value;
            }
        }

        protected void SOSiteStatusSelected_AttributeID1_FieldSelecting(PXCache sender, PXFieldSelectingEventArgs e)
        {
            if (e.Row == null) return;

            //CSAnswers attr = PXSelect<CSAnswers,
            //        Where<CSAnswers.entityID, Equal<Current<SOSiteStatusSelected.inventoryID>>>>.SelectSingleBound(Base, new object[] { e.Row });

            CSAnswers attr = PXSelectJoin<CSAnswers,
                     LeftJoin<InventoryItem, On<CSAnswers.entityID, Equal<InventoryItem.inventoryID>>,
                     LeftJoin<CSAttributeGroup, On<CSAttributeGroup.entityClassID, Equal<InventoryItem.itemClassID>>>>,
                     Where<CSAttributeGroup.sortOrder, Equal<int_1>, And<CSAnswers.entityID, Equal<Current<SOSiteStatusSelected.inventoryID>>,
                     And<CSAttributeGroup.attributeID, Equal<CSAnswers.attributeID>>>>>.SelectSingleBound(Base, new object[] { e.Row });
            if (attr != null)
            {
                e.ReturnValue = attr.AttributeID;
            }
        }
        #endregion show attributeID and attributeValue 1

        #region show attributeID & attributeValue 2
        protected void SOSiteStatusSelected_AttributeValue2_FieldSelecting(PXCache sender, PXFieldSelectingEventArgs e)
        {
            if (e.Row == null) return;

            CSAnswers attr = PXSelectJoin<CSAnswers,
                     LeftJoin<InventoryItem, On<CSAnswers.entityID, Equal<InventoryItem.inventoryID>>,
                     LeftJoin<CSAttributeGroup, On<CSAttributeGroup.entityClassID, Equal<InventoryItem.itemClassID>>>>,
                     Where<CSAttributeGroup.sortOrder, Equal<int_2>, And<CSAnswers.entityID, Equal<Current<SOSiteStatusSelected.inventoryID>>,
                     And<CSAttributeGroup.attributeID, Equal<CSAnswers.attributeID>>>>>.SelectSingleBound(Base, new object[] { e.Row });
            if (attr != null)
            {
                e.ReturnValue = attr.Value;
            }
        }

        protected void SOSiteStatusSelected_AttributeID2_FieldSelecting(PXCache sender, PXFieldSelectingEventArgs e)
        {
            if (e.Row == null) return;

            //CSAnswers attr = PXSelect<CSAnswers,
            //        Where<CSAnswers.entityID, Equal<Current<SOSiteStatusSelected.inventoryID>>>>.SelectSingleBound(Base, new object[] { e.Row });

            CSAnswers attr = PXSelectJoin<CSAnswers,
                      LeftJoin<InventoryItem, On<CSAnswers.entityID, Equal<InventoryItem.inventoryID>>,
                      LeftJoin<CSAttributeGroup, On<CSAttributeGroup.entityClassID, Equal<InventoryItem.itemClassID>>>>,
                      Where<CSAttributeGroup.sortOrder, Equal<int_2>, And<CSAnswers.entityID, Equal<Current<SOSiteStatusSelected.inventoryID>>,
                      And<CSAttributeGroup.attributeID, Equal<CSAnswers.attributeID>>>>>.SelectSingleBound(Base, new object[] { e.Row });
            if (attr != null)
            {
                e.ReturnValue = attr.AttributeID;
            }
        }
        #endregion show attributeID and attributeValue 2

        #region show attributeID & attributeValue 3
        protected void SOSiteStatusSelected_AttributeValue3_FieldSelecting(PXCache sender, PXFieldSelectingEventArgs e)
        {
            if (e.Row == null) return;

            CSAnswers attr = PXSelectJoin<CSAnswers,
                     LeftJoin<InventoryItem, On<CSAnswers.entityID, Equal<InventoryItem.inventoryID>>,
                     LeftJoin<CSAttributeGroup, On<CSAttributeGroup.entityClassID, Equal<InventoryItem.itemClassID>>>>,
                     Where<CSAttributeGroup.sortOrder, Equal<int_3>, And<CSAnswers.entityID, Equal<Current<SOSiteStatusSelected.inventoryID>>,
                     And<CSAttributeGroup.attributeID, Equal<CSAnswers.attributeID>>>>>.SelectSingleBound(Base, new object[] { e.Row });
            if (attr != null)
            {
                e.ReturnValue = attr.Value;
            }
        }

        protected void SOSiteStatusSelected_AttributeID3_FieldSelecting(PXCache sender, PXFieldSelectingEventArgs e)
        {
            if (e.Row == null) return;

            //CSAnswers attr = PXSelect<CSAnswers,
            //        Where<CSAnswers.entityID, Equal<Current<SOSiteStatusSelected.inventoryID>>>>.SelectSingleBound(Base, new object[] { e.Row });

            CSAnswers attr = PXSelectJoin<CSAnswers,
                    LeftJoin<InventoryItem, On<CSAnswers.entityID, Equal<InventoryItem.inventoryID>>,
                    LeftJoin<CSAttributeGroup, On<CSAttributeGroup.entityClassID, Equal<InventoryItem.itemClassID>>>>,
                    Where<CSAttributeGroup.sortOrder, Equal<int_3>, And<CSAnswers.entityID, Equal<Current<SOSiteStatusSelected.inventoryID>>,
                    And<CSAttributeGroup.attributeID, Equal<CSAnswers.attributeID>>>>>.SelectSingleBound(Base, new object[] { e.Row });
            if (attr != null)
            {
                e.ReturnValue = attr.AttributeID;
            }
        }
        #endregion show attributeID and attributeValue 3

        #region show attributeID & attributeValue 4
        protected void SOSiteStatusSelected_AttributeValue4_FieldSelecting(PXCache sender, PXFieldSelectingEventArgs e)
        {
            if (e.Row == null) return;

            CSAnswers attr = PXSelectJoin<CSAnswers,
                     LeftJoin<InventoryItem, On<CSAnswers.entityID, Equal<InventoryItem.inventoryID>>,
                     LeftJoin<CSAttributeGroup, On<CSAttributeGroup.entityClassID, Equal<InventoryItem.itemClassID>>>>,
                     Where<CSAttributeGroup.sortOrder, Equal<int_4>, And<CSAnswers.entityID, Equal<Current<SOSiteStatusSelected.inventoryID>>,
                     And<CSAttributeGroup.attributeID, Equal<CSAnswers.attributeID>>>>>.SelectSingleBound(Base, new object[] { e.Row });
            if (attr != null)
            {
                e.ReturnValue = attr.Value;
            }
        }

        protected void SOSiteStatusSelected_AttributeID4_FieldSelecting(PXCache sender, PXFieldSelectingEventArgs e)
        {
            if (e.Row == null) return;

            //CSAnswers attr = PXSelect<CSAnswers,
            //        Where<CSAnswers.entityID, Equal<Current<SOSiteStatusSelected.inventoryID>>>>.SelectSingleBound(Base, new object[] { e.Row });

            CSAnswers attr = PXSelectJoin<CSAnswers,
                     LeftJoin<InventoryItem, On<CSAnswers.entityID, Equal<InventoryItem.inventoryID>>,
                     LeftJoin<CSAttributeGroup, On<CSAttributeGroup.entityClassID, Equal<InventoryItem.itemClassID>>>>,
                     Where<CSAttributeGroup.sortOrder, Equal<int_4>, And<CSAnswers.entityID, Equal<Current<SOSiteStatusSelected.inventoryID>>,
                     And<CSAttributeGroup.attributeID, Equal<CSAnswers.attributeID>>>>>.SelectSingleBound(Base, new object[] { e.Row });
            if (attr != null)
            {
                e.ReturnValue = attr.AttributeID;
            }
        }
        #endregion show attributeID and attributeValue 4

        #region show attributeID & attributeValue 5
        protected void SOSiteStatusSelected_AttributeValue5_FieldSelecting(PXCache sender, PXFieldSelectingEventArgs e)
        {
            if (e.Row == null) return;

            CSAnswers attr = PXSelectJoin<CSAnswers,
                     LeftJoin<InventoryItem, On<CSAnswers.entityID, Equal<InventoryItem.inventoryID>>,
                     LeftJoin<CSAttributeGroup, On<CSAttributeGroup.entityClassID, Equal<InventoryItem.itemClassID>>>>,
                     Where<CSAttributeGroup.sortOrder, Equal<int_5>, And<CSAnswers.entityID, Equal<Current<SOSiteStatusSelected.inventoryID>>,
                     And<CSAttributeGroup.attributeID, Equal<CSAnswers.attributeID>>>>>.SelectSingleBound(Base, new object[] { e.Row });
            if (attr != null)
            {
                e.ReturnValue = attr.Value;
            }
        }

        protected void SOSiteStatusSelected_AttributeID5_FieldSelecting(PXCache sender, PXFieldSelectingEventArgs e)
        {
            if (e.Row == null) return;

            //CSAnswers attr = PXSelect<CSAnswers,
            //        Where<CSAnswers.entityID, Equal<Current<SOSiteStatusSelected.inventoryID>>>>.SelectSingleBound(Base, new object[] { e.Row });

            CSAnswers attr = PXSelectJoin<CSAnswers,
                    LeftJoin<InventoryItem, On<CSAnswers.entityID, Equal<InventoryItem.inventoryID>>,
                    LeftJoin<CSAttributeGroup, On<CSAttributeGroup.entityClassID, Equal<InventoryItem.itemClassID>>>>,
                    Where<CSAttributeGroup.sortOrder, Equal<int_5>, And<CSAnswers.entityID, Equal<Current<SOSiteStatusSelected.inventoryID>>,
                    And<CSAttributeGroup.attributeID, Equal<CSAnswers.attributeID>>>>>.SelectSingleBound(Base, new object[] { e.Row });
            if (attr != null)
            {
                e.ReturnValue = attr.AttributeID;
            }
        }
        #endregion show attributeID and attributeValue 5

        #region show attributeID & attributeValue 6
        protected void SOSiteStatusSelected_AttributeValue6_FieldSelecting(PXCache sender, PXFieldSelectingEventArgs e)
        {
            if (e.Row == null) return;

            CSAnswers attr = PXSelectJoin<CSAnswers,
                     LeftJoin<InventoryItem, On<CSAnswers.entityID, Equal<InventoryItem.inventoryID>>,
                     LeftJoin<CSAttributeGroup, On<CSAttributeGroup.entityClassID, Equal<InventoryItem.itemClassID>>>>,
                     Where<CSAttributeGroup.sortOrder, Equal<int_6>, And<CSAnswers.entityID, Equal<Current<SOSiteStatusSelected.inventoryID>>,
                     And<CSAttributeGroup.attributeID, Equal<CSAnswers.attributeID>>>>>.SelectSingleBound(Base, new object[] { e.Row });
            if (attr != null)
            {
                e.ReturnValue = attr.Value;
            }
        }

        protected void SOSiteStatusSelected_AttributeID6_FieldSelecting(PXCache sender, PXFieldSelectingEventArgs e)
        {
            if (e.Row == null) return;

            //CSAnswers attr = PXSelect<CSAnswers,
            //        Where<CSAnswers.entityID, Equal<Current<SOSiteStatusSelected.inventoryID>>>>.SelectSingleBound(Base, new object[] { e.Row });

            CSAnswers attr = PXSelectJoin<CSAnswers,
                      LeftJoin<InventoryItem, On<CSAnswers.entityID, Equal<InventoryItem.inventoryID>>,
                      LeftJoin<CSAttributeGroup, On<CSAttributeGroup.entityClassID, Equal<InventoryItem.itemClassID>>>>,
                      Where<CSAttributeGroup.sortOrder, Equal<int_6>, And<CSAnswers.entityID, Equal<Current<SOSiteStatusSelected.inventoryID>>,
                      And<CSAttributeGroup.attributeID, Equal<CSAnswers.attributeID>>>>>.SelectSingleBound(Base, new object[] { e.Row });
            if (attr != null)
            {
                e.ReturnValue = attr.AttributeID;
            }
        }
        #endregion show attributeID and attributeValue 6

    }

    
}
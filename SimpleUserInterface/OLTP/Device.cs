//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleUserInterface.OLTP
{
    using System;
    using System.Collections.Generic;
    
    public partial class Device
    {
        public int DeviceID { get; set; }
        public int BehaviorScenario { get; set; }
        public int Location { get; set; }
        public int Type { get; set; }
        public string Name { get; set; }
        public Nullable<System.DateTime> LastReplyTime { get; set; }
        public Nullable<int> DataName { get; set; }
        public Nullable<int> Data { get; set; }
    
        public virtual DataName DataName1 { get; set; }
        public virtual Location Location1 { get; set; }
        public virtual Scenario Scenario { get; set; }
        public virtual Type Type1 { get; set; }
    }
}

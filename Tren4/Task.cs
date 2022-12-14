//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Tren4
{
    using System;
    using System.Collections.Generic;
    
    public partial class Task
    {
        public int ID { get; set; }
        public int ExecutorID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public System.DateTime CreateDateTime { get; set; }
        public System.DateTime Deadline { get; set; }
        public double Difficulty { get; set; }
        public int Time { get; set; }
        public int StatusID { get; set; }
        public Nullable<int> WorkTypeID { get; set; }
        public Nullable<System.DateTime> CompletedDateTime { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Executor Executor { get; set; }
        public virtual Status Status { get; set; }
        public virtual WorkType WorkType { get; set; }
    }
}

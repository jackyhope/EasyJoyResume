﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace EasyJoyResume.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EasyJoy589452Entities : DbContext
    {
        public EasyJoy589452Entities()
            : base("name=EasyJoy589452Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EJ_RESUME_BANK547852> EJ_RESUME_BANK547852 { get; set; }
        public virtual DbSet<EJ_MY_RESUME652145> EJ_MY_RESUME652145 { get; set; }
        public virtual DbSet<EJ_USER241856> EJ_USER241856 { get; set; }
    
        public virtual int EJ_RESUME_SAVE(Nullable<int> rESUMEID, Nullable<int> mEMBERID, Nullable<int> iTEM_ID, string jSON)
        {
            var rESUMEIDParameter = rESUMEID.HasValue ?
                new ObjectParameter("RESUMEID", rESUMEID) :
                new ObjectParameter("RESUMEID", typeof(int));
    
            var mEMBERIDParameter = mEMBERID.HasValue ?
                new ObjectParameter("MEMBERID", mEMBERID) :
                new ObjectParameter("MEMBERID", typeof(int));
    
            var iTEM_IDParameter = iTEM_ID.HasValue ?
                new ObjectParameter("ITEM_ID", iTEM_ID) :
                new ObjectParameter("ITEM_ID", typeof(int));
    
            var jSONParameter = jSON != null ?
                new ObjectParameter("JSON", jSON) :
                new ObjectParameter("JSON", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("EJ_RESUME_SAVE", rESUMEIDParameter, mEMBERIDParameter, iTEM_IDParameter, jSONParameter);
        }
    
        public virtual int P_EJ_RESUME_SAVE(Nullable<int> rESUMEID, Nullable<int> mEMBERID, Nullable<int> iTEM_ID, string jSON)
        {
            var rESUMEIDParameter = rESUMEID.HasValue ?
                new ObjectParameter("RESUMEID", rESUMEID) :
                new ObjectParameter("RESUMEID", typeof(int));
    
            var mEMBERIDParameter = mEMBERID.HasValue ?
                new ObjectParameter("MEMBERID", mEMBERID) :
                new ObjectParameter("MEMBERID", typeof(int));
    
            var iTEM_IDParameter = iTEM_ID.HasValue ?
                new ObjectParameter("ITEM_ID", iTEM_ID) :
                new ObjectParameter("ITEM_ID", typeof(int));
    
            var jSONParameter = jSON != null ?
                new ObjectParameter("JSON", jSON) :
                new ObjectParameter("JSON", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("P_EJ_RESUME_SAVE", rESUMEIDParameter, mEMBERIDParameter, iTEM_IDParameter, jSONParameter);
        }
    }
}
//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBHandlerForMySQL.YDVS
{
    using System;
    using System.Collections.Generic;
    
    public partial class base_train_proprietorship
    {
        public int id { get; set; }
        public Nullable<int> order { get; set; }
        public string train_type { get; set; }
        public string train_no { get; set; }
        public string locomotive_depot { get; set; }
        public string work_shop { get; set; }
        public string creator { get; set; }
        public Nullable<System.DateTime> creat_time { get; set; }
        public string modifier { get; set; }
        public Nullable<System.DateTime> update_time { get; set; }
    }
}
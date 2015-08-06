using Castle.ActiveRecord;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTend.Entites
{
    [ActiveRecord("TenderFilters")]
    public class TenderFilter : BaseEntity<TenderFilter>
    {
        [BelongsTo("UserId")]
        public UserSystem User { get; set; }

        [BelongsTo("ThemeId")]
        public TenderTheme Theme { get; set; }
    }
}

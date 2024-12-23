using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project5_DapperNorthwind.Dtos.CategoryDtos
{
    public class ResultCategoryDto // Bütün listeleme işlemleri için kullanıcagımız kategori sınıfı
    {
        // Listeleme için kullanıcagımız Dto'muz
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
    }
}

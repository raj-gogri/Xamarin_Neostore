using NeoStore.Loginpage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeoStore.HomePage
{
    public class CombineData
    {
        public UserDetailsResponseData user_data { get; set; }
        public ProductCategoriesResponse[] product_categories { get; set; }
    }
}

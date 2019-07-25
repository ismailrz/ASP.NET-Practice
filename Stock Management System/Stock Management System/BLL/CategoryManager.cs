using Stock_Management_System.Models;
using Stock_Management_System.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Management_System.BLL
{
    class CategoryManager
    {
        CategoryRepository _categoryRepository;
        public CategoryManager()
        {
            _categoryRepository = new CategoryRepository();
        }
        public bool IsCategoryUnique(CategoryModel category)
        {
            return _categoryRepository.IsCategoryUnique(category);
        }
        public string InsertCategory(CategoryModel category)
        {
            return _categoryRepository.InsertCategory(category);
        }
        public DataTable LoadCategoryToComboBox()
        {
            return _categoryRepository.LoadCategoryToComboBox();
        }
    }
}

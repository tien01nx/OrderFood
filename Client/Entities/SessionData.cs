
using DataAccess.Model;

namespace Client.Entities
{
    public static class SessionData
    {
        private static Restaurant _currentRestaurant;
        private static List<Restaurant> _restaurantList = new List<Restaurant>();

        private static Category _currentCategory;
        private static List<Category> _categoryList = new List<Category>();

        public static Category CurrentCategory
        {
            get { return _currentCategory; }
            set { _currentCategory = value; }
        }

        public static IReadOnlyList<Category> AllCategories => _categoryList.AsReadOnly();
        public static Restaurant CurrentRestaurant
        {
            get { return _currentRestaurant; }
            set { _currentRestaurant = value; }
        }

        public static IReadOnlyList<Restaurant> AllRestaurants => _restaurantList.AsReadOnly();


        public static void AddRestaurant(Restaurant restaurant)
        {
            if (restaurant != null && !_restaurantList.Contains(restaurant))
            {
                _restaurantList.Add(restaurant);
            }
        }

        public static void RemoveRestaurant(Restaurant restaurant)
        {
            if (restaurant != null)
            {
                _restaurantList.Remove(restaurant);


            }
        }

        public static void RemoveRestaurantById(string id)
        {
            var restaurantToRemove = _restaurantList.FirstOrDefault(r => r.Id == id);
            if (restaurantToRemove != null)
            {
                _restaurantList.Remove(restaurantToRemove);
            }
        }





        // thêm vào danh sách
        public static void AddCategory(Category category)
        {
            if (category != null && !_categoryList.Contains(category))
            {
                _categoryList.Add(category);
            }
        }
        // xóa khỏi danh sách
        public static void RemoveCategory(Category category)
        {
            if (category != null)
            {
                _categoryList.Remove(category);
            }
        }

        // xóa theo id
        public static void RemoveCategoryById(string id)
        {
            var categoryToRemove = _categoryList.FirstOrDefault(c => c.Id == id);
            if (categoryToRemove != null)
            {
                _categoryList.Remove(categoryToRemove);
            }
        }




    }
}

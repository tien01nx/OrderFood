
using Client.Model;


namespace Client.Entities
{
    public static class SessionData
    {
        private static RestaurantVM _currentRestaurant;
        private static List<RestaurantVM> _restaurantList = new List<RestaurantVM>();

        private static Category _currentCategory;
        private static List<Category> _categoryList = new List<Category>();

        public static Category CurrentCategory
        {
            get { return _currentCategory; }
            set { _currentCategory = value; }
        }


        // lấy danh sách nhà hàng 
        private static RestaurantVM _getAllRestaurant;
        private static List<RestaurantVM> _getAllRestaurantList = new List<RestaurantVM>();
        private static RestaurantVM GetAllRestaurant
        {
            get { return _getAllRestaurant; }
            set { _getAllRestaurant = value; }
        }

        public static IReadOnlyList<RestaurantVM> GetAllRestaurants => _getAllRestaurantList.AsReadOnly();

        public static void addAllRestaurant(RestaurantVM restaurant)
        {
            if (restaurant != null && !_getAllRestaurantList.Contains(restaurant))
            {
                _getAllRestaurantList.Add(restaurant);
            }
        }
        // xóa hết khỏi list
        public static void removeAllRestaurant(RestaurantVM restaurant)
        {
            if (restaurant != null)
            {
                _getAllRestaurantList.Remove(restaurant);
            }
        }
        // xóa theo id

        public static void removeAllRestaurantById(string id)
        {
            var restaurantToRemove = _getAllRestaurantList.FirstOrDefault(r => r.Id == id);
            if (restaurantToRemove != null)
            {
                _getAllRestaurantList.Remove(restaurantToRemove);
            }
        }


        public static IReadOnlyList<Category> AllCategories => _categoryList.AsReadOnly();
        public static RestaurantVM CurrentRestaurant
        {
            get { return _currentRestaurant; }
            set { _currentRestaurant = value; }
        }

        public static IReadOnlyList<RestaurantVM> AllRestaurants => _restaurantList.AsReadOnly();


        public static void AddRestaurant(RestaurantVM restaurant)
        {
            if (restaurant != null && !_restaurantList.Contains(restaurant))
            {
                _restaurantList.Add(restaurant);
            }
        }

        public static void RemoveRestaurant(RestaurantVM restaurant)
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

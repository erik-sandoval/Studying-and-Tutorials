import { createAppContainer } from "react-navigation";
import { createStackNavigator } from "react-navigation-stack";
import CategoriesScreen from "../screens/categories.component";
import CategoryMealsScreen from "../screens/category-meals.component";
import MealDetailScreen from "../screens/meal-detail.component";
import Colors from "../constants/Colors";
import { Platform } from "react-native";

const MealsNavigator = createStackNavigator(
  {
    Categories: CategoriesScreen,
    CategoryMeals: CategoryMealsScreen,
    MealDetail: MealDetailScreen,
  },
  {
    defaultNavigationOptions: {
      headerStyle: {
        backgroundColor: Platform.OS === "android" ? Colors.primaryColor : "",
      },
      headerTintColor: Platform.OS === "android" ? "#fff" : Colors.primaryColor,
    },
  }
);

export default createAppContainer(MealsNavigator);

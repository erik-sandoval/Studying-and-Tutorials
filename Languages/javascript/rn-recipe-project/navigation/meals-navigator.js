import { createAppContainer } from "react-navigation";
import { createStackNavigator } from "react-navigation-stack";
import CategoriesScreen from "../screens/categories.component";
import CategoryMealsScreen from "../screens/category-meals.component";
import MealDetailScreen from "../screens/meal-detail.component";

const MealsNavigator = createStackNavigator({
  Categories: CategoriesScreen,
  CategoryMeals: CategoryMealsScreen,
  MealDetail: MealDetailScreen,
});

export default createAppContainer(MealsNavigator);

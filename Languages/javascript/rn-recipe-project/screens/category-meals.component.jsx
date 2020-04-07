import React from "react";
import { StyleSheet, Text, View, Button } from "react-native";

const CategoryMealsScreen = ({ navigation }) => {
  return (
    <View style={styles.screen}>
      <Text>The Category Meals Screen!</Text>
      <Button title="Go Back" onPress={() => navigation.goBack()}></Button>
      <Button
        title="Go To Meal Detail"
        onPress={() => navigation.navigate("MealDetail")}
      ></Button>
    </View>
  );
};

export default CategoryMealsScreen;

const styles = StyleSheet.create({
  screen: {
    flex: 1,
    justifyContent: "center",
    alignItems: "center",
  },
});

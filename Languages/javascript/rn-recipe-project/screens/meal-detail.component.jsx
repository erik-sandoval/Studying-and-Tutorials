import React from "react";
import { StyleSheet, Text, View, Button } from "react-native";

const MealDetailScreen = ({ navigation }) => {
  return (
    <View style={styles.screen}>
      <Text>The Meal Detail Screen!</Text>
      <Button
        title="Go Back to Categories"
        onPress={() => navigation.popToTop()}
      ></Button>
    </View>
  );
};

export default MealDetailScreen;

const styles = StyleSheet.create({
  screen: {
    flex: 1,
    justifyContent: "center",
    alignItems: "center",
  },
});

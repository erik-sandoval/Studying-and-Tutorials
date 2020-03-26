import React, { useState } from "react";
import { StyleSheet, View, FlatList, Button } from "react-native";
import GoalItem from "./components/goalItem.component";
import GoalInput from "./components/goalInput.component";

export default function App() {
  const [courseGoals, setCourseGoals] = useState([]);

  const addGoalHandler = enteredGoal => {
    setCourseGoals(currentGoals => [
      ...currentGoals,
      { key: Math.random().toString(), goal: enteredGoal }
    ]);
  };

  const removeGoalHandler = goalKey => {
    setCourseGoals(currentGoals => {
      return currentGoals.filter(goal => goal.key !== goalKey);
    });
  };

  return (
    <View style={styles.screen}>
      <GoalInput addGoal={addGoalHandler} />
      <FlatList
        data={courseGoals}
        renderItem={({ item }) => (
          <GoalItem deleteItem={removeGoalHandler} item={item} />
        )}
      ></FlatList>
    </View>
  );
}

const styles = StyleSheet.create({
  screen: {
    paddingVertical: 40,
    paddingHorizontal: 20,
    justifyContent: "center"
  },
  inputContainer: {
    flexDirection: "row",
    justifyContent: "space-between",
    alignItems: "center",
    marginBottom: 10
  },
  input: {
    borderBottomColor: "black",
    borderWidth: 1,
    paddingVertical: 4,
    paddingHorizontal: 10,
    width: 300
  }
});

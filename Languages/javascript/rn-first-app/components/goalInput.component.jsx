import React, { useState } from "react";
import { StyleSheet, TextInput, View, Button } from "react-native";

const GoalInput = ({ addGoal }) => {
  const [enteredGoal, setEnteredGoal] = useState("");

  const goalInputHandler = enteredText => {
    setEnteredGoal(enteredText);
  };

  return (
    <View style={styles.inputContainer}>
      <TextInput
        placeholder="Course Goal"
        style={styles.input}
        onChangeText={goalInputHandler}
        value={enteredGoal}
      ></TextInput>
      <Button title="ADD" onPress={() => addGoal(enteredGoal)}></Button>
    </View>
  );
};

export default GoalInput;

const styles = StyleSheet.create({
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

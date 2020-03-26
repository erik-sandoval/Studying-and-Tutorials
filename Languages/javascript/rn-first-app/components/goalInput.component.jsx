import React, { useState } from "react";
import { StyleSheet, TextInput, View, Button, Modal } from "react-native";

const GoalInput = ({ addGoal, isVisible, cancelAddGoal }) => {
  const [enteredGoal, setEnteredGoal] = useState("");

  const goalInputHandler = enteredText => {
    setEnteredGoal(enteredText);
  };

  const addGoalHandler = () => {
    addGoal(enteredGoal);
    setEnteredGoal("");
  };

  const cancelGoalHandler = () => {
    cancelAddGoal();
    setEnteredGoal("");
  };

  return (
    <Modal visible={isVisible} animationType="slide">
      <View style={styles.inputContainer}>
        <TextInput
          placeholder="Course Goal"
          style={styles.input}
          onChangeText={goalInputHandler}
          value={enteredGoal}
        ></TextInput>
        <View style={styles.buttonContainer}>
          <View style={[styles.cancelButton, styles.button]}>
            <Button
              title="CANCEL"
              color="red"
              onPress={cancelGoalHandler}
            ></Button>
          </View>
          <View style={styles.button}>
            <Button title="ADD" onPress={addGoalHandler}></Button>
          </View>
        </View>
      </View>
    </Modal>
  );
};

export default GoalInput;

const styles = StyleSheet.create({
  inputContainer: {
    justifyContent: "center",
    alignItems: "center",
    marginBottom: 10,
    flex: 1
  },
  input: {
    borderBottomColor: "black",
    marginBottom: 15,
    borderWidth: 1,
    paddingVertical: 10,
    paddingHorizontal: 10,
    width: 300,
    color: "black"
  },
  buttonContainer: {
    flexDirection: "row",
    justifyContent: "flex-end",
    width: 300,
    marginTop: 10
  },
  button: {
    width: 100
  },
  cancelButton: {
    marginRight: 20
  }
});

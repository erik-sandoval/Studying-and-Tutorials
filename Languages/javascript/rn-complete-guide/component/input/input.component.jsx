import React from "react";
import { TextInput, StyleSheet } from "react-native";

const Input = ({ style, ...rest }) => {
  return <TextInput {...rest} style={[styles.input, style]}></TextInput>;
};

const styles = StyleSheet.create({
  input: {
    height: 30,
    borderBottomColor: "grey",
    borderBottomWidth: 1,
    marginVertical: 10
  }
});

export default Input;

import React, { useState } from "react";
import { StyleSheet, Text, TextInput, View, Button } from "react-native";

export default function App() {
  const [outputText, setOutputText] = useState("dfsdfsdfsd");
  return (
    <View
      style={{
        padding: 50,
        justifyContent: "center"
      }}
    >
      <View
        style={{
          flexDirection: "row",
          justifyContent: "space-evenly",
          alignItems: "center"
        }}
      >
        <TextInput
          placeholder="Course Goal"
          style={{
            borderBottomColor: "black",
            borderWidth: 1,
            padding: 10,
            width: 200
          }}
        ></TextInput>
        <Button title="ADD" style={{ padding: 10 }}></Button>
      </View>
    </View>
  );
}

const styles = StyleSheet.create({});
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
  },
  listItemContainer: {},
  listItem: {
    padding: 10,
    backgroundColor: "#ccc",
    borderColor: "black",
    borderWidth: 1,
    marginVertical: 10
  }
});

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

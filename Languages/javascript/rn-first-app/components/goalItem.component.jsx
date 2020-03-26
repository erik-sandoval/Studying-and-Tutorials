import React from "react";

import { StyleSheet, Text, View } from "react-native";

const GoalItem = ({ item: { goal } }) => {
  return (
    <View>
      <Text style={styles.listItem}>{goal}</Text>
    </View>
  );
};

export default GoalItem;

const styles = StyleSheet.create({
  listItem: {
    padding: 10,
    backgroundColor: "#ccc",
    borderColor: "black",
    borderWidth: 1,
    marginVertical: 10
  }
});

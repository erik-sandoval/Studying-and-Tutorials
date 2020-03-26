import React from "react";

import { StyleSheet, Text, View, TouchableOpacity } from "react-native";

const GoalItem = ({ item: { key, goal }, deleteItem }) => {
  return (
    <TouchableOpacity activeOpacity={0.8} onPress={() => deleteItem(key)}>
      <View>
        <Text style={styles.listItem}>{goal}</Text>
      </View>
    </TouchableOpacity>
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

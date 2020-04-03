import React from "react";
import { StyleSheet, Text, View, Platform } from "react-native";
import colors from "../../constants/colors";
import TitleText from "../styled-text/title-text.component";

const Header = ({ title }) => {
  return (
    <View
      style={[
        styles.headerBase,
        Platform.select({
          ios: styles.headerIOS,
          android: styles.headerAndroid
        })
      ]}
    >
      <TitleText style={styles.title}>{title}</TitleText>
    </View>
  );
};

const styles = StyleSheet.create({
  headerBase: {
    width: "100%",
    height: 90,
    paddingTop: 36,
    alignItems: "center",
    justifyContent: "center"
  },
  headerIOS: {
    borderBottomColor: "#ccc",
    borderBottomWidth: 1,
    backgroundColor: "white"
  },
  headerAndroid: {
    backgroundColor: colors.primary
  },
  title: {
    color: Platform.OS === "ios" ? colors.primary : "white"
  }
});

export default Header;

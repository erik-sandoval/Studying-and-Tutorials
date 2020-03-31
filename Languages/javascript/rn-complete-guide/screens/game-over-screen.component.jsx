import React from "react";
import { StyleSheet, Text, View, Button } from "react-native";
import BodyText from "../component/styled-text/body-text.component";
import TitleText from "../component/styled-text/title-text.component";

const GameOverScreen = ({ userNumber, roundsNumber, onRestart }) => {
  return (
    <View style={styles.screen}>
      <TitleText>The Game is Over!</TitleText>
      <BodyText>Number of rounds: {roundsNumber}</BodyText>
      <BodyText>Number was: {userNumber}</BodyText>
      <Button title="RESTART" onPress={onRestart}></Button>
    </View>
  );
};

export default GameOverScreen;

const styles = StyleSheet.create({
  screen: {
    flex: 1,
    justifyContent: "center",
    alignItems: "center"
  }
});

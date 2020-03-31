import React from "react";
import { StyleSheet, View, Button, Image, Text } from "react-native";
import BodyText from "../component/styled-text/body-text.component";
import TitleText from "../component/styled-text/title-text.component";
import colors from "../constants/colors";
import PrimaryButton from "../component/custom-buttons/primary-button.component";

const GameOverScreen = ({ userNumber, roundsNumber, onRestart }) => {
  return (
    <View style={styles.screen}>
      <TitleText>The Game is Over!</TitleText>
      <View style={styles.imageContainer}>
        <Image
          source={require("../assets/success.png")}
          style={styles.image}
        ></Image>
      </View>
      <View style={styles.resultContainer}>
        <BodyText style={styles.resultText}>
          Your phone took{" "}
          <Text style={styles.textHightLight}>{roundsNumber}</Text>{" "}
          {roundsNumber > 1 ? "rounds" : "round"} to guess the number{" "}
          <Text style={styles.textHightLight}>{userNumber}</Text>.
        </BodyText>
      </View>
      <PrimaryButton onPress={onRestart}>NEW GAME</PrimaryButton>
    </View>
  );
};

export default GameOverScreen;

const styles = StyleSheet.create({
  screen: {
    flex: 1,
    justifyContent: "center",
    alignItems: "center"
  },
  imageContainer: {
    width: 300,
    height: 300,
    borderRadius: 150,
    borderColor: "black",
    borderWidth: 3,
    marginVertical: 30,
    overflow: "hidden"
  },
  resultContainer: {
    marginHorizontal: 30,
    marginVertical: 15
  },
  resultText: {
    textAlign: "center",
    fontSize: 20
  },
  image: {
    width: "100%",
    height: "100%"
  },
  textHightLight: {
    color: colors.primary,
    fontWeight: "700"
  }
});

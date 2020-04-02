import React from "react";
import {
  StyleSheet,
  View,
  Button,
  Image,
  Text,
  Dimensions,
  ScrollView
} from "react-native";

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
    alignItems: "center",
    marginVertical: Dimensions.get("window").height / 40
  },
  imageContainer: {
    width: Dimensions.get("window").width * 0.7,
    height: Dimensions.get("window").width * 0.7,
    borderRadius: (Dimensions.get("window").width * 0.7) / 2,
    borderColor: "black",
    borderWidth: 3,
    marginVertical: Dimensions.get("window").height / 40,
    overflow: "hidden"
  },
  resultContainer: {
    marginHorizontal: 30,
    marginVertical: Dimensions.get("window").height / 60
  },
  resultText: {
    textAlign: "center",
    fontSize: Dimensions.get("window").height < 400 ? 16 : 20
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

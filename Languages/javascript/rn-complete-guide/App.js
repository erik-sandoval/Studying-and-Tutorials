import React, { useState } from "react";
import { StyleSheet, View } from "react-native";
import Header from "./component/header/header.component";
import StartGameScreen from "./screens/start-game-screen.component";
import GameScreen from "./screens/game-screen.component";
import GameOverScreen from "./screens/game-over-screen.component";

export default function App() {
  const [userNumber, setUserNumber] = useState();
  const [guessRounds, setGuessRounds] = useState(0);

  const startGameHandler = selectedNumber => {
    setUserNumber(selectedNumber);
    setGuessRounds(0);
  };

  const gameOverHandler = numOfRounds => {
    setGuessRounds(numOfRounds);
  };

  const configureNewGameHandler = () => {
    setUserNumber(null);
    setGuessRounds(0);
  };
  return (
    <View style={styles.screen}>
      <Header title="Guess a Number"></Header>
      <StartGameScreen></StartGameScreen>
    </View>
  );
}

const styles = StyleSheet.create({
  screen: {
    flex: 1
  }
});

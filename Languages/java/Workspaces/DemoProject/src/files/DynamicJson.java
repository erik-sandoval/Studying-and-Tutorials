package files;

import org.testng.annotations.Test;

import io.restassured.RestAssured;

import static io.restassured.RestAssured.*;

public class DynamicJson {

	@Test
	public void addBook() {

		RestAssured.baseURI = "https://rahulshettyacademy.com";
		given().header("Content-Type", "application/json").body(payload.AddBook()).when().post("/Library/Addbook.php").then().assertThat();

	}

}

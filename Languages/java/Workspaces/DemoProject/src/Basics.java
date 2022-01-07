import io.restassured.RestAssured;
import static io.restassured.RestAssured.*;
import static org.hamcrest.Matchers.*;

import files.payload;

public class Basics {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		RestAssured.baseURI = "https://rahulshettyacademy.com";
		String res = given().queryParam("key", "qaclick123").header("Content-Type", "application/json")
				.body(payload.AddPlace()).when().post("maps/api/place/add/json").then().assertThat().statusCode(200)
				.body("scope", equalTo("APP")).header("Server", "Apache/2.4.18 (Ubuntu)").extract().response()
				.asString();

		JsonPath js = new JsonPath(res);

		String placeId = js.get("place_id");

		given().queryParam("key", "qaclick123").header("Content-Type", "application/json")
				.body("{\n" + "\"place_id\":\"" + placeId + "\",\n" + "\"address\":\"70 Summer walk, USA\",\n"
						+ "\"key\":\"qaclick123\"\n" + "}")
				.when().put("maps/api/place/update/json").then().assertThat().statusCode(200)
				.body("msg", equalTo("Address successfully updated"));
	}

}

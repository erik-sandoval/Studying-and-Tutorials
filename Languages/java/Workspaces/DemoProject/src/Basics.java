import io.restassured.RestAssured;
import static io.restassured.RestAssured.*;

import static org.hamcrest.Matchers.*;

import org.testng.Assert;

import files.ReusableMethods;
import files.payload;

public class Basics {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		RestAssured.baseURI = "https://rahulshettyacademy.com";
		String res = given().queryParam("key", "qaclick123").header("Content-Type", "application/json")
				.body(payload.AddPlace()).when().post("maps/api/place/add/json").then().assertThat().statusCode(200)
				.body("scope", equalTo("APP")).header("Server", "Apache/2.4.18 (Ubuntu)").extract().response()
				.asString();

		String placeId = ReusableMethods.jsonConvert(res).get("place_id");

		String newPlace = "293 Something Test, USA";

		given().queryParam("key", "qaclick123").header("Content-Type", "application/json")
				.body("{\n" + "\"place_id\":\"" + placeId + "\",\n" + "\"address\":\"" + newPlace + "\",\n"
						+ "\"key\":\"qaclick123\"\n" + "}")
				.when().put("maps/api/place/update/json").then().assertThat().statusCode(200)
				.body("msg", equalTo("Address successfully updated"));

		String getPlaceRes = given().queryParam("key", "qaclick123").queryParam("place_id", placeId).when()
				.get("maps/api/place/get/json").then().assertThat().statusCode(200).extract().response().asString();

		String actualAddress = ReusableMethods.jsonConvert(getPlaceRes).get("address");

		Assert.assertEquals(actualAddress, newPlace);

	}

}

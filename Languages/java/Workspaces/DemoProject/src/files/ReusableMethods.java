package files;

import io.restassured.path.json.JsonPath;

public class ReusableMethods {

	public static JsonPath jsonConvert(String res) {

		JsonPath js = new JsonPath(res);

		return js;
	}

}

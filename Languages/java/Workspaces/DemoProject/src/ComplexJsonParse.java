import files.payload;
import io.restassured.path.json.JsonPath;

public class ComplexJsonParse {

	public static void main(String[] args) {

		JsonPath js = new JsonPath(payload.CoursePrice());

		int count = js.getInt("courses.size()");

		int purchaseAmount = js.getInt("dashboard.purchaseAmount");

		for (int i = 0; i < count; i++) {
			String title = js.get("courses[" + i + "].title");
			int price = js.get("courses[" + i + "].price");

			System.out.println(title + " price: $" + price + ".00");
		}

		System.out.println(purchaseAmount);
	}

}

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

		for (int i = 0; i < count; i++) {
			String title = js.get("courses[" + i + "].title");

			if (title.equals("RPA")) {

				int price = js.get("courses[" + i + "].price");

				System.out.println(title + " price: $" + price + ".00");

				break;

			}

		}

		int coursePriceTotal = 0;

		for (int i = 0; i < count; i++) {
			int price = js.get("courses[" + i + "].price");
			int copies = js.get("courses[" + i + "].copies");

			coursePriceTotal += price * copies;

		}

		if (coursePriceTotal == purchaseAmount) {
			System.out.println(coursePriceTotal + " equals the purchase amount " + purchaseAmount);
		}

	}

}

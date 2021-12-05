import java.util.ArrayList;
import java.util.Iterator;

public class JavaBrushUp {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		int myNum = 5;
		String name = "Erik";
		char letter = 'r';
		double dec = 5.99;
		boolean boo = true;
		
		MethodsDemo test = new MethodsDemo();

		test.getData();

		int[] arr = new int[5];

		arr[0] = 1;
		arr[1] = 2;
		arr[2] = 3;
		arr[3] = 4;
		arr[4] = 5;

		int[] arr2 = { 1, 2, 3, 4, 5 };

		// create object of a class
		ArrayList<String> a = new ArrayList<String>();

		a.add("Erik");
		a.add("Me");

		System.out.println(a.get(1));

		// for loop

		for (int i = 0; i < arr2.length; i++) {
			System.out.println(arr2[i]);
		}

		for (int n : arr2) {
			System.out.println(n);
		}

	}

}

import org.openqa.selenium.WebDriver;
import org.openqa.selenium.chrome.ChromeDriver;
import org.openqa.selenium.edge.EdgeDriver;
import org.openqa.selenium.firefox.FirefoxDriver;

public class SelIntro {

	public static void main(String[] args) {

		// Chrome
		System.setProperty("webdriver.chrome.driver", "C:\\Users\\sando\\Documents\\Web Drivers\\chromedriver.exe");

		// WebDriver driver = new ChromeDriver();

		// Firefox
		System.setProperty("webdriver.gecko.driver", "C:\\Users\\sando\\Documents\\Web Drivers\\geckodriver.exe");

		// WebDriver driver = new FirefoxDriver();

		// Edge
		System.setProperty("webdriver.edge.driver", "C:\\Users\\sando\\Documents\\Web Drivers\\msedgedriver.exe");

		WebDriver driver = new EdgeDriver();

		driver.get("https://www.apple.com");
		System.out.println(driver.getTitle());
		System.out.println(driver.getCurrentUrl());
		driver.getPageSource();
		driver.quit();
	}

}

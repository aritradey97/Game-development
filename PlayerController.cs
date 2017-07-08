using UnityEngine;

// Include the namespace required to use Unity UI
using UnityEngine.UI;

using System.Collections;

public class PlayerController : MonoBehaviour {

	// Create public variables for player speed, and for the Text UI game objects
	public float speed;
	public Text countText;
	public Text winText;
	private bool jumping = false;
	private float jumpheight = 1;
	// Create private references to the rigidbody component on the player, and the count of pick up objects picked up so far
	private Rigidbody rb;
	private int count;

	// At the start of the game..
	void Start ()
	{
		// Assign the Rigidbody component to our private rb variable
		rb = GetComponent<Rigidbody>();
		if (Input.GetKeyDown (KeyCode.Space )){
			rb.AddForce(new Vector3(0,jumpheight,0));
		}
		// Set the count to zero 
		count = 0;

		// Run the SetCountText function to update the UI (see below)
		SetCountText ();

		// Set the text property of our Win Text UI to an empty string, making the 'You Win' (game over message) blank
		winText.text = "";

	}

	// Each physics step..
	void FixedUpdate ()
	{
		// Set some local float variables equal to the value of our Horizontal and Vertical Inputs
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		// Create a Vector3 variable, and assign X and Z to feature our horizontal and vertical float variables above
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		// Add a physical force to our Player rigidbody using our 'movement' Vector3 above, 
		// multiplying it by 'speed' - our public player speed that appears in the inspector
		rb.AddForce (movement * speed);
		if (Input.GetKeyDown(KeyCode.Space) && jumping == false)
		{
			rb.AddForce(new Vector3(0, jumpheight, 0), ForceMode.Impulse);
			jumping = true;
		}
		jumping = false;
	}

	// When this game object intersects a collider with 'is trigger' checked, 
	// store a reference to that collider in a variable named 'other'..
	void OnTriggerEnter(Collider other) 
	{
		// ..and if the game object we intersect has the tag 'Pick Up' assigned to it..
		if (other.gameObject.CompareTag ("Pick Up"))
		{
			// Make the other game object (the pick up) inactive, to make it disappear
			other.gameObject.SetActive (false);

			// Add one to the score variable 'count'
			count = count + 1;

			// Run the 'SetCountText()' function (see below)
			SetCountText ();
		}
	}

    // Create a standalone function that can update the 'countText' UI and check if the required amount to win has been achieved
    void SetCountText()
    {
        // Update the text field of our 'countText' variable
        if (count == 0)
            countText.text = "Count: " + count.ToString();
        else if (count == 1)
            countText.text = "Count: " + count.ToString() + "\nBetween 1912 and 1948, art competitions were a part of the Olympics. Medals were awarded for architecture, music, painting, and sculpture.";
        else if (count == 2)
            countText.text = "Count: " + count.ToString() + "\nThe first webcam watched a coffee pot. It allowed researchers at Cambridge to monitor the coffee situation without leaving their desks.";
        else if (count == 3)
            countText.text = "Count: " + count.ToString() + "\nThe entire state of Wyoming only has two escalators.";
        else if (count == 4)
            countText.text = "Count: " + count.ToString() + "\nThe ampersand symbol is formed from the letters in et—the Latin word for 'and'";
        else if (count == 5)
            countText.text = "Count: " + count.ToString() + "\n Ravens in captivity can learn to talk better than parrots.";
        else if (count == 6)
            countText.text = "Count: " + count.ToString() + "\n The actor who was inside R2-D2 hated the guy who played C-3PO, calling him 'the rudest man I've ever met.'";
        else if (count == 7)
            countText.text = "Count: " + count.ToString() + "\nIt's a myth that no two snowflakes are exactly the same. In 1988, a scientist found two identical snow crystals. They came from a storm in Wisconsin.";
        else if (count == 8)
            countText.text = "Count: " + count.ToString() + "\nWhen Disneyland opened in 1955, 'Tomorrowland' was designed to look like a year in the distant future: 1986.";
        else if (count == 9)
            countText.text = "Count: " + count.ToString() + "\n Before George W. Bush took office, some Clinton staffers canvassed the White House offices and removed the W key from over 60 keyboards.";
        else if (count == 10)
            countText.text = "Count: " + count.ToString() + "\n When the last official Blockbuster Video closed in November 2013, the final rental was the apocalyptic comedy This Is the End.";

        else if (count == 11)
            countText.text = "Count: " + count.ToString() + "\nThe German word kummerspeck means excess weight gained from emotional overeating. Literally, grief bacon.";
        else if (count == 12)
            countText.text = "Count: " + count.ToString() + "\nThe collective noun for a group of pugs is a grumble.";
        else if (count == 13)
            countText.text = "Count: " + count.ToString() + "\nIn 1939, Hitler's nephew wrote an article called 'Why I Hate My Uncle.' He came to the U.S., served in the Navy, and settled on Long Island.";
        else if (count == 14)
            countText.text = "Count: " + count.ToString() + "\nAccording to an analysis by FiveThirtyEight, 44 percent of Bob Ross's paintings contain at least one 'happy little cloud.'";
        else if (count == 15)
            countText.text = "Count: " + count.ToString() + "\nOn an April day in 1930, the BBC reported, 'There is no news.' Instead they played piano music.";
        else if (count == 16)
            countText.text = "Count: " + count.ToString() + "\n Johnny Cash's 'A Boy Named Sue' was penned by beloved children's author Shel Silverstein.";
        else if (count == 17)
            countText.text = "Count: " + count.ToString() + "\n Ben & Jerry learned how to make ice cream by taking a $5 correspondence course offered by Penn State. (They decided to split one course.)";
        else if (count == 18)
            countText.text = "Count: " + count.ToString() + "\nThe word 'PEZ' comes from the German word for peppermint—PfeffErminZ.";
        else if (count == 19)
            countText.text = "Count: " + count.ToString() + "\nIn the 1970s, Mattel sold a doll called 'Growing Up Skipper.' Her breasts grew when her arm was turned.";
        else if (count == 20)
            countText.text = "Count: " + count.ToString() + "\n Before Sally Ride became the first American woman in space, a reporter asked, 'Do you weep when things go wrong on the job?'";

        else if (count == 21)
            countText.text = "Count: " + count.ToString() + "\nIn the 1980s, Pablo Escobar's Medellin Cartel was spending $2,500 a month on rubber bands just to hold all their cash.";
        else if (count == 22)
            countText.text = "Count: " + count.ToString() + "\nThe inventor of the AK-47 has said he wishes he'd invented something to help farmers instead — 'for example a lawnmower.'";
        else if (count == 23)
            countText.text = "Count: " + count.ToString() + "\nThe Vatican Bank is the world's only bank that allows ATM users to perform transactions in Latin.";
        else if (count == 24)
            countText.text = "Count: " + count.ToString() + "\nThe duffel bag gets its name from the town of Duffel, Belgium, where the cloth used in the bags was originally sold.";
        else if (count == 25)
            countText.text = "Count: " + count.ToString() + "\n James Avery ('Uncle Phil' on The Fresh Prince of Bel Air) was the voice of Shredder on the Teenage Mutant Ninja Turtles cartoon.";
        else if (count == 26)
            countText.text = "Count: " + count.ToString() + "\n At Fatburger, you can order a 'Hypocrite'—a veggie burger topped with crispy strips of bacon.";
        else if (count == 27)
            countText.text = "Count: " + count.ToString() + "\nWhen asked who owned the patent on the polio vaccine, Jonas Salk said, 'Well, the people. There is no patent. Could you patent the sun ? '";
        else if (count == 28)
            countText.text = "Count: " + count.ToString() + "\n The Q in Q-tips stands for quality.";
        else if (count == 29)
            countText.text = "Count: " + count.ToString() + "\nEditor Bennett Cerf challenged Dr. Seuss to write a book using no more than 50 different words. The result? Green Eggs and Ham.";
        else if (count == 30)
            countText.text = "Count: " + count.ToString() + "\n The act of stretching and yawning is called pandiculation.";

        else if (count == 31)
            countText.text = "Count: " + count.ToString() + "\nSea cucumbers eat with their feet.";
        else if (count == 32)
            countText.text = "Count: " + count.ToString() + "\nA murder suspect was convicted after the broken-off leg of a grasshopper in his pants cuff turned out to be a perfect match for an insect found near the victim's body.";
        else if (count == 33)
            countText.text = "Count: " + count.ToString() + "\nAfter an online vote in 2011, Toyota announced that the official plural of Prius was Prii.";
        else if (count == 34)
            countText.text = "Count: " + count.ToString() + "\nIn his book, Dick Cheney says his yellow lab Dave was banned from Camp David for attacking President Bush's dog Barney.";
        else if (count == 35)
            countText.text = "Count: " + count.ToString() + "\nLyme disease is named after the town of Lyme, Connecticut, where several cases were identified in 1975.";
        else if (count == 36)
            countText.text = "Count: " + count.ToString() + "\nReno is farther west than Los Angeles.";
        else if (count == 37)
            countText.text = "Count: " + count.ToString() + "\nWilliam Faulkner refused a dinner invitation from JFK's White House. 'Why that’s a hundred miles away,' he said. 'That’s a long way to go just to eat.'";
        else if (count == 38)
            countText.text = "Count: " + count.ToString() + "\nIn 1907, an ad campaign for Kellogg's Corn Flakes offered a free box of cereal to any woman who would wink at her grocer.";
        else if (count == 39)
            countText.text = "Count: " + count.ToString() + "\nWhy did the FBI call Ted Kaczynski 'The Unabomber'? Because his early mail bombs were sent to universities (UN) & airlines (A).";
        else if (count == 40)
            countText.text = "Count: " + count.ToString() + "\nObsessive nose picking is called rhinotillexomania.";

        else if (count == 41)
            countText.text = "Count: " + count.ToString() + "\n 'Silver Bells' was called 'Tinkle Bells' until co-composer Jay Livingston’s wife told him 'tinkle' had another meaning.";
        else if (count == 42)
            countText.text = "Count: " + count.ToString() + "\nMichael Jackson's 1988 autobiography Moonwalk was edited by Jacqueline Kennedy Onassis.";
        else if (count == 43)
            countText.text = "Count: " + count.ToString() + "\n How did Curious George get to America? He was captured in Africa by The Man With the Yellow Hat — with his yellow hat.";
        else if (count == 44)
            countText.text = "Count: " + count.ToString() + "\nIn the early stage version of The Wizard of Oz, Dorothy’s faithful companion Toto was replaced by a cow named Imogene.";
        else if (count == 45)
            countText.text = "Count: " + count.ToString() + "\nTobias Fünke's 'nevernude' condition on Arrested Development is real. It's called 'gymnophobia' — the fear of nude bodies.";
        else if (count == 46)
            countText.text = "Count: " + count.ToString() + "\nHawaiian Punch was originally developed as a tropical flavored ice cream topping.";
        else if (count == 47)
            countText.text = "Count: " + count.ToString() + "\n Andy's evil neighbor Sid from Toy Story returns briefly as the garbage man in Toy Story 3.";
        else if (count == 48)
            countText.text = "Count: " + count.ToString() + "\nJacuzzi is a brand name. You can also buy Jacuzzi toilets and mattresses.";
        else if (count == 49)
            countText.text = "Count: " + count.ToString() + "\n During a 2004 episode of Sesame Street, Cookie Monster said that before he started eating cookies, his name was Sid.";
        else if (count == 50)
            countText.text = "Count: " + count.ToString() + "\nRoger Ebert and Oprah Winfrey went on a couple dates in the mid-1980s. It was Roger who convinced her to syndicate her talk show.";

        else if (count == 51)
            countText.text = "Count: " + count.ToString() + "\nFredric Baur invented the Pringles can. When he passed away in 2008, his ashes were buried in one.";
        else if (count == 52)
            countText.text = "Count: " + count.ToString() + "\nWhen he appeared on Wait Wait...Don't Tell Me!, Bill Clinton correctly answered three questions about My Little Pony: Friendship Is Magic.";
        else if (count == 53)
            countText.text = "Count: " + count.ToString() + "\nThe archerfish knocks its insect prey out of over-hanging branches with a stream of spit.";
        else if (count == 54)
            countText.text = "Count: " + count.ToString() + "\nThere really was a Captain Morgan. He was a Welsh pirate who later became the lieutenant governor of Jamaica.";
        else if (count == 55)
            countText.text = "Count: " + count.ToString() + "\nIn 1961, Martha Stewart was selected as one of Glamour magazine;s 'Ten Best-Dressed College Girls.'";
        else if (count == 56)
            countText.text = "Count: " + count.ToString() + "\n At the 1905 wedding of Franklin and Eleanor Roosevelt, President Teddy Roosevelt gave away the bride.";
        else if (count == 57)
            countText.text = "Count: " + count.ToString() + "\nSorry, parents. According to NASA's FAQ page, 'There are no plans at this time to send children into space.'";
        else if (count == 58)
            countText.text = "Count: " + count.ToString() + "\nGod and Jesus are the only characters on The Simpsons with a full set of fingers and toes.";
        else if (count == 59)
            countText.text = "Count: " + count.ToString() + "\nThe sum of all the numbers on a roulette wheel is 666.";
        else if (count == 60)
            countText.text = "Count: " + count.ToString() + "\nOnly one McDonald's in the world has turquoise arches. Government officials in Sedona, Arizona, thought the yellow would look bad with the natural red rock of the city.";

        else if (count == 61)
            countText.text = "Count: " + count.ToString() + "\nBrenda Lee was only 13 when she recorded ''Rockin' Around the Christmas Tree.'";
        else if (count == 62)
            countText.text = "Count: " + count.ToString() + "\nDolly Parton once entered a Dolly Parton look-a-like contest—and lost.";
        else if (count == 63)
            countText.text = "Count: " + count.ToString() + "\nDuring the Coolidge presidency, the First Family had a pet raccoon named Rebecca who liked to play in the White House bathtub.";
        else if (count == 64)
            countText.text = "Count: " + count.ToString() + "\nAfter OutKast sang 'Shake it like a Polaroid picture,' Polaroid released this statement: 'Shaking or waving can actually damage the image.'";
        else if (count == 65)
            countText.text = "Count: " + count.ToString() + "\n In Peanuts in 1968, Snoopy trained to become a champion arm-wrestler. In the end, he was disqualified for not having thumbs.";
        else if (count == 66)
            countText.text = "Count: " + count.ToString() + "\n In France, the Ashton Kutcher/Natalie Portman movie No Strings Attached was called Sex Friends.";
        else if (count == 67)
            countText.text = "Count: " + count.ToString() + "\nThe famous 'Heisman pose' is based on Ed Smith, a former NYU running back who modeled for the trophy’s sculptor in 1934.";
        else if (count == 68)
            countText.text = "Count: " + count.ToString() + "\nFor $45, the U.S. Bureau of Engraving and Printing will sell you a 5-lb bag with $10,000 worth of shredded U.S. currency.";
        else if (count == 69)
            countText.text = "Count: " + count.ToString() + "\nBefore going with Blue Devils, Duke considered the nicknames Blue Eagles, Royal Blazes, Blue Warriors and Polar Bears.";
        else if (count == 70)
            countText.text = "Count: " + count.ToString() + "\nBefore settling on the Seven Dwarfs we know today, Disney also considered Chesty, Tubby, Burpy, Deafy, Hickey, Wheezy, and Awful.";
        // Check if our 'count' is equal to or exceeded 12
        if (count == 70)
        {
            // Set the text value of our 'winText'
            winText.text = "You Win!";
        }
    }
}
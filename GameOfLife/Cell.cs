
public class Cell
{
	private bool alive = false;//Ï¸°û×´Ì¬
    public bool Alive { get { return alive; }set { alive = value; } }

	public void die() { alive = false; }
	public void reborn() { alive = true; }
	public bool isAlive() { return alive; }
}

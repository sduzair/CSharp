var heroPoints = 10;
var monsterPoints = 10;

var damage = new Random();
do
{
    //hero attack
    var monsterDamage = damage.Next(1, 11);
    monsterPoints -= monsterDamage;
    System.Console.WriteLine($"Monster: Lost {monsterDamage} Remaining {monsterPoints}");

    //monster attack
    var heroDamage = damage.Next(1, 11);
    heroPoints -= heroDamage;
    System.Console.WriteLine($"Hero: Lost {heroDamage} Remaining {heroPoints}");

} while (heroPoints > 0 && monsterPoints > 0);

if (heroPoints > 0)
{
    System.Console.WriteLine("Hero wins!");
}
if (monsterPoints > 0)
{
    System.Console.WriteLine("Monster wins!");
}
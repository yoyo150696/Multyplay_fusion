the progress of the game:
This is a multiplayer game which any user can connect from his computer and enter with a player into the game.
As soon as the participant activates the game then the game gives him a player in a random place on the board.
The player starts with 100 life points and can shoot straight according to the direction he is looking, every shot that hits lowers 20 points to the victim and increases 10 points to the attacker.
There is a shield in the space of the board they played can pick it up and if the other player hits the shield then hit does nothing.

Code example - 

collision ball with player/shield:
  
    bool first = true;
        void OnTriggerEnter(Collider other){
            
            if(first){
                Debug.Log(other.name);
                if(other.name == "Shield"){
                    Destroy(gameObject);
                    return;
                }
                Health d = other.GetComponent<Health>();
                d.DealDamageRpc(20);
                Debug.Log(name);
                Ball b  =  GetComponent<Ball>();
                b.PlayerHealth.addDamageRpc(10);
            }
        
        }
I did that if the bullet hits the shield then the bullet is destroyed and if it hits a person then it activates the life functions

collision player with shield:

    void OnTriggerEnter(Collider other){

        if(other.name == "Ball(Clone)"){
            Debug.Log("here");
            Destroy(other);
            return;
        }
        if(transform.parent == null){
            transform.SetParent(other.transform);
        }
    }
If the shield does not belong to any player then the player becomes its 'parent'.

ball spawner:
 void Update()
    {
        if (!HasStateAuthority)  return;

        if(Input.GetKeyDown(KeyCode.S)){
            GameObject newObjet = Instantiate(Ball,BallSpawnPoint.transform.position,BallSpawnPoint.transform.rotation);
            Ball b = newObjet.GetComponent<Ball>();
            Health h = GetComponentInParent<Health>();
            b.ChangePlayer(h);
        }
    }

itch - https://yoyo1516.itch.io/multyplayergame

enjoy the game:))

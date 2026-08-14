static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
      => !knightIsAwake;
    // {
    //     if(knightIsAwake==true){
    //         return false;        **my first answer**
    //     }else{
    //         return true;
    //     }
    // }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
       => knightIsAwake || archerIsAwake || prisonerIsAwake;
      // if(knightIsAwake || archerIsAwake || prisonerIsAwake== true){
      //     return true;
      // }else  { return false;  }        
    

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    => archerIsAwake==false && prisonerIsAwake==true;

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    => (petDogIsPresent==true && archerIsAwake==false)||(petDogIsPresent==false && prisonerIsAwake==true&& archerIsAwake==false&& knightIsAwake==false );
    
}

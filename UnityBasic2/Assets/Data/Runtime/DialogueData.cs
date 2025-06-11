using UnityEngine;
using System.Collections;

///
/// !!! Machine generated code !!!
/// !!! DO NOT CHANGE Tabs to Spaces !!!
/// 
[System.Serializable]
public class DialogueData
{
  [SerializeField]
  int id;
  public int ID { get {return id; } set { this.id = value;} }
  
  [SerializeField]
  int character_id;
  public int Character_ID { get {return character_id; } set { this.character_id = value;} }
  
  [SerializeField]
  int position;
  public int Position { get {return position; } set { this.position = value;} }
  
  [SerializeField]
  string bg;
  public string BG { get {return bg; } set { this.bg = value;} }
  
  [SerializeField]
  string dialogue;
  public string Dialogue { get {return dialogue; } set { this.dialogue = value;} }
  
}
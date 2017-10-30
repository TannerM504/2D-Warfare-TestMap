 public void createMessage(string text, Color color)
 {
     if(color == null)
     {
         color = Color.green;
     }
     if(text == null)
     {
         text = "";
     }

     GameObject newText = new GameObject(text.Replace(" ", "-"), typeof(RectTransform));
     var newTextComp = newText.AddComponent<Text>();
     //newText.AddComponent<CanvasRenderer>();

     //Text newText = transform.gameObject.AddComponent<Text>();
     newTextComp.text = text;
     newTextComp.font = fontMessage;
     newTextComp.color = color;
     newTextComp.alignment = TextAnchor.MiddleCenter;
     newTextComp.fontSize = 10;

     newText.transform.SetParent(transform);

 }
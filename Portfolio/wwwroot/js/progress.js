function startAnimation(elementId, targetWidth) {
    const element = document.getElementById(elementId);
    let currentWidth = parseInt(element.style.width, 10);
    
    const speed = 1;
  
    const animation = setInterval(frame, 50);
  
    function frame() {
      if (currentWidth >= targetWidth) {
        clearInterval(animation);
      } else {
        currentWidth += speed;
        element.style.width = currentWidth + '%';
        element.innerHTML = currentWidth + '%';
      }
    }
  }
  
  startAnimation('element1', 70);
  startAnimation('element2', 60); 
  startAnimation('element3', 60);
  startAnimation('element4', 65);
  startAnimation('element5', 50);
  startAnimation('element6', 70);
  startAnimation('element7', 60);
  startAnimation('element8', 45);
  startAnimation('element9', 75);
  startAnimation('element10', 90);
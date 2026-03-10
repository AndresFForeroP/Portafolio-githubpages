mergeInto(LibraryManager.library, {
  OpenGameInOverlay: function(urlPtr) {
    var url = UTF8ToString(urlPtr);
    
    var overlay = document.createElement('div');
    overlay.id = 'game-overlay';
    overlay.style.cssText = `
      position: fixed; top: 0; left: 0;
      width: 100vw; height: 100vh;
      background: rgba(0,0,0,0.85);
      z-index: 9999;
      display: flex;
      flex-direction: column;
      align-items: center;
      justify-content: center;
    `;
    
    var closeBtn = document.createElement('button');
    closeBtn.innerText = '✕ Cerrar';
    closeBtn.style.cssText = `
      margin-bottom: 10px;
      padding: 8px 20px;
      background: #fff;
      border: none;
      cursor: pointer;
      font-size: 16px;
      border-radius: 4px;
    `;
    closeBtn.onclick = function() {
      document.body.removeChild(overlay);
    };
    
    var iframe = document.createElement('iframe');
    iframe.src = url;
    iframe.style.cssText = `
      width: 90vw;
      height: 85vh;
      border: 2px solid #fff;
      border-radius: 8px;
    `;
    iframe.allowFullscreen = true;
    
    overlay.appendChild(closeBtn);
    overlay.appendChild(iframe);
    document.body.appendChild(overlay);
  }
});
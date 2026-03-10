mergeInto(LibraryManager.library, {
  OpenGameInOverlay: function(urlPtr) {
    var url = UTF8ToString(urlPtr);
    
    var overlay = document.createElement('div');
    overlay.id = 'game-overlay';
    overlay.style.cssText = `
      position: fixed; top: 0; left: 0;
      width: 100vw; height: 100vh;
      background: rgba(0, 5, 20, 0.92);
      z-index: 9999;
      display: flex;
      flex-direction: column;
      align-items: center;
      justify-content: center;
    `;

    var container = document.createElement('div');
    container.style.cssText = `
      display: flex;
      flex-direction: column;
      align-items: center;
      width: 980px;
      height: 660px;
      background: linear-gradient(160deg, #020d1f 60%, #041830 100%);
      border: 2px solid #3af;
      border-radius: 6px;
      box-shadow:
        0 0 8px #3af,
        0 0 24px #1af,
        inset 0 0 20px rgba(0, 140, 255, 0.08);
      padding: 12px;
      box-sizing: border-box;
      position: relative;
    `;

    ['top-left','top-right','bottom-left','bottom-right'].forEach(function(pos) {
      var corner = document.createElement('div');
      var isTop  = pos.includes('top');
      var isLeft = pos.includes('left');
      corner.style.cssText = `
        position: absolute;
        width: 14px; height: 14px;
        ${isTop  ? 'top: -2px'  : 'bottom: -2px'};
        ${isLeft ? 'left: -2px' : 'right: -2px'};
        border-color: #7df;
        border-style: solid;
        border-width: ${isTop ? '3px' : '0'} ${isLeft ? '0' : '3px'} ${isTop ? '0' : '3px'} ${isLeft ? '3px' : '0'};
        border-radius: ${isTop && isLeft ? '4px 0 0 0' : isTop ? '0 4px 0 0' : isLeft ? '0 0 0 4px' : '0 0 4px 0'};
      `;
      container.appendChild(corner);
    });

    var topBar = document.createElement('div');
    topBar.style.cssText = `
      width: 100%;
      display: flex;
      justify-content: flex-end;
      align-items: center;
      gap: 8px;
      margin-bottom: 10px;
    `;

    var btnStyle = `
      width: 30px;
      height: 30px;
      background: transparent;
      border: 1px solid #3af;
      color: #7df;
      cursor: pointer;
      font-size: 16px;
      border-radius: 3px;
      box-shadow: 0 0 6px #3af, inset 0 0 6px rgba(0,140,255,0.1);
      transition: all 0.2s;
      display: flex;
      align-items: center;
      justify-content: center;
      padding: 0;
    `;

    var openBtn = document.createElement('button');
    openBtn.innerHTML = '⛶';
    openBtn.style.cssText = btnStyle;
    openBtn.title = 'Abrir en pestaña nueva';
    openBtn.onmouseover = function() {
      this.style.background = 'rgba(0,140,255,0.2)';
      this.style.boxShadow  = '0 0 12px #3af, inset 0 0 10px rgba(0,140,255,0.2)';
    };
    openBtn.onmouseout = function() {
      this.style.background = 'transparent';
      this.style.boxShadow  = '0 0 6px #3af, inset 0 0 6px rgba(0,140,255,0.1)';
    };
    openBtn.onclick = function() {
      window.open(url, '_blank');
    };

    var closeBtn = document.createElement('button');
    closeBtn.innerHTML = '✕';
    closeBtn.style.cssText = btnStyle;
    closeBtn.title = 'Cerrar';
    closeBtn.onmouseover = function() {
      this.style.background = 'rgba(0,140,255,0.2)';
      this.style.boxShadow  = '0 0 12px #3af, inset 0 0 10px rgba(0,140,255,0.2)';
    };
    closeBtn.onmouseout = function() {
      this.style.background = 'transparent';
      this.style.boxShadow  = '0 0 6px #3af, inset 0 0 6px rgba(0,140,255,0.1)';
    };
    closeBtn.onclick = function() {
      document.body.removeChild(overlay);
    };

    topBar.appendChild(openBtn);
    topBar.appendChild(closeBtn);

    var iframe = document.createElement('iframe');
    iframe.src = url;
    iframe.scrolling = 'no';
    iframe.style.cssText = `
      width: 960px;
      height: 600px;
      border: 1px solid #1af;
      border-radius: 4px;
      box-shadow: 0 0 10px rgba(0,140,255,0.3), inset 0 0 20px rgba(0,0,30,0.5);
      background: #000;
      overflow: hidden;
    `;
    iframe.allowFullscreen = true;

    container.appendChild(topBar);
    container.appendChild(iframe);
    overlay.appendChild(container);
    document.body.appendChild(overlay);
  }
});
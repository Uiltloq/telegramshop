import { useEffect } from 'react';
import './App.css'

const tg = window.Telegram.WebApp;

function App() {

  useEffect(()=>{
    tg.ready();
  },[]);

  const handleClose = () => {
    th.close();
  };

  return (
    <>
      <div>
        <span>Добро пожаловать!!</span>
        <div>
          <button onClick={handleClose}>Закрыть</button>
        </div>
      </div>
    </>
  )
}

export default App

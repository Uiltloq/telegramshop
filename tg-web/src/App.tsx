import { useEffect } from 'react';
import './App.css'

const tg = window.Telegram.WebApp;

const App = () => {

  useEffect(()=>{
    tg.ready();
  },[]);

  const handleClose = () => {
    tg.close();
  }

  return(
    <div>
      Work
      <button onClick={handleClose}>Закрыть</button>
    </div>
  )
};

export default App;
import logo from './bowlers.png';

function Header() {
  return (
    <header className="header navbar navbar-light bg-dark">
      <div className="col-4">
        <img src={logo} alt="Bowling Logo" className="logo" />
      </div>
      <div>
        <h1 className="col subtitle text-white">Bowling Leauge Information</h1>
      </div>
    </header>
  );
}

export default Header;

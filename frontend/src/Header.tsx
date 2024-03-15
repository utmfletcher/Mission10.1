import logo from './bowlers.png';

function Header() {
  return (
    <header className="header navbar navbar-dark bg-dark">
      <div className="container">
        <div className="row align-items-center">
          <div className="col-2">
            <img src={logo} alt="Bowling Logo" className="logo" />
          </div>
          <div className="col-10">
            <h1 className="title text-white">Bowling League Information</h1>
          </div>
        </div>
      </div>
    </header>
  );
}

export default Header;
